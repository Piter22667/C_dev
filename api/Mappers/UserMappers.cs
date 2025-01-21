using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using api.Dto;

namespace api.Mappers
{

    public static class UserMappers
    {
        public static UsersDto ToUsersDto(this Users usersModel)
        {
            return new UsersDto
            {
                Id = usersModel.Id,
                login = usersModel.login,
                password = usersModel.password,
                name = usersModel.name,
                surname = usersModel.surname,
                lastName = usersModel.lastName
            };
        }
    }
}
