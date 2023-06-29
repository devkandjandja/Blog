using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class UseRepositorio : Repositorio<User>
    {
        private readonly SqlConnection _connection;       
        public UseRepositorio(SqlConnection connection) : base (connection)
        => _connection = connection;

        public List<User> GetWithRoles()
        {
            var query = @"
            select 
            [User].*
            [Role].*
            from
            [User]
            left join [UserRole] on [UserRole].[UserId] = [User]
            left join [Role] on [UserRole].[RoleId] = [Role]";

            var users =new List<User>();

            var items = _connection.Query<User, Role, User>(
                query, 
                (user, role) => {
                    var usr = users.FirstOrDefault(x => x.Id == user.Id);
                    if(usr == null)
                    {
                        usr = user;
                        if(role != null)
                         usr.Roles.Add(role);
                         
                        users.Add(usr);
                    }
                    else
                     usr.Roles.Add(role);

                    return user;
                }, splitOn: "Id");
            return users;
        }
    }
}

