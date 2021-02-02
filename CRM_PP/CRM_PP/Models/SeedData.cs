using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CRM_PP.Data;
using System;
using System.Linq;

namespace CRM_PP.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CRMContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CRMContext>>()))
            {
                //Check if anything in DB
                if (context.User.Any())
                {
                    return;
                }

                context.User.AddRange(
                    new User
                    {
                        name = "Jan",
                        surname = "Kowalski",
                        dateOfBirth = DateTime.Parse("1997-3-12"),
                        login = "JK1",
                        passwordMd5 = "abc",
                        idRoli = 1,
                        isDeleted = 0
                    },
                    new User
                    {
                        name = "Karol",
                        surname = "Nowak",
                        dateOfBirth = DateTime.Parse("1990-3-20"),
                        login = "KN1",
                        passwordMd5 = "abc",
                        idRoli = 1,
                        isDeleted = 0
                    },
                    new User
                    {
                        name = "Kinga",
                        surname = "Nowak",
                        dateOfBirth = DateTime.Parse("1978-8-17"),
                        login = "KN2",
                        passwordMd5 = "abc",
                        idRoli = 1,
                        isDeleted = 0
                    },
                    new User
                    {
                        name = "Karol",
                        surname = "Narty",
                        dateOfBirth = DateTime.Parse("1974-1-1"),
                        login = "KN3",
                        passwordMd5 = "abc",
                        idRoli = 1,
                        isDeleted = 0
                    }
                );
                context.SaveChanges();
            }



        }

    }
}

