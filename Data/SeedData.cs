using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace LanchesMac.Data
{
    public static class SeedData
    {
        public static async Task CreateRoles(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            //incluir perfis customizados
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            //define os perfis em um array de strings
            string[] roleNames = { "Admin", "Member" };
            IdentityResult roleResult;

            //verifica se já existe na base
            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
            }

            //cria um super-usuário para manter a aplicação Web
            var powerUser = new IdentityUser
            {
                //obtem dados do arquivo Json de configuração 
                UserName = configuration.GetSection("UserSettings")["UserName"],
                Email = configuration.GetSection("UserSettings")["UserEmail"]
            };

            //obter a senha do arquivo Json de configuração
            string userPassword = configuration.GetSection("UserSettings")["UserPassword"];

            //verifica se existe um usuário cadastrado com o email informado, caso não exista cria o super-usuário
            //na base de dados
            var user = await UserManager.FindByEmailAsync(powerUser.Email);
            if (user == null)
            {
                var createPowerUser = await UserManager.CreateAsync(powerUser, userPassword);
                if (createPowerUser.Succeeded)
                    //atribui o usuário ao perfil Admin
                    await UserManager.AddToRoleAsync(powerUser, "Admin");
            }


        }
    }
}
