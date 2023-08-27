namespace Marwin.Infrastructure.Migrations
{
    using Marwin.Core.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Runtime.Remoting.Contexts;
    using System.Xml.Serialization;

    internal sealed class Configuration : DbMigrationsConfiguration<Marwin.Infrastructure.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Marwin.Infrastructure.Data.ApplicationDbContext context)
        {
            //Инициализация начального списка компаний
            SeedDefaultCompanies(context);
            //Инициализация начального списка сотрудников
            SeedDefaultEmployees(context);

            base.Seed(context);
        }

        private void SeedDefaultCompanies(Marwin.Infrastructure.Data.ApplicationDbContext context)
        {
            Company[] defaultCommpanies = new Company[]
            {
                new Company()
                {
                    CompanyId = Guid.Parse("82c9ed86-3e81-4a64-8d5e-d4c38f730a21"),
                    CompanyName = "Bubblemix",
                    BIN = "501520695917",
                    Address = "37 Express Street",
                    Note = "Изысканные пузырьки в каждой капле!"
                },new Company()
                {
                    CompanyId = Guid.Parse("49f65196-72c2-4709-bc31-265af947edd9"),
                    CompanyName = "Dabfeed",
                    BIN = "438341268478",
                    Address = "829 Crowley Circle",
                    Note = "Погрузитесь в мир контента с легкостью и стилем."
                },new Company()
                {
                    CompanyId = Guid.Parse("ffb62ce2-a867-4b47-903a-f377cfd571b6"),
                    CompanyName = "Feedspan",
                    BIN = "842534460028",
                    Address = "72745 Beilfuss Trail",
                    Note = "Глобальные новости на вашей ладони."
                },new Company()
                {
                    CompanyId = Guid.Parse("2ff63a86-275a-4f19-86db-59e0a3a2b5fd"),
                    CompanyName = "Trilith",
                    BIN = "621575708582",
                    Address = "67339 Pierstorff Plaza",
                    Note = "Строим будущее камень за камнем."
                },new Company()
                {
                    CompanyId = Guid.Parse("76703cae-5aa2-4ee4-8109-a1dacbed14ed"),
                    CompanyName = "Kayveo",
                    BIN = "107499747215",
                    Address = "642 Di Loreto Lane",
                    Note = "Ваш партнер в путешествии к успеху"
                }
            };
            context.Companies.AddOrUpdate(defaultCommpanies);
        }

        private void SeedDefaultEmployees(Marwin.Infrastructure.Data.ApplicationDbContext context)
        {
            Employee[] defaultEmployees = new Employee[]
            {
                //"CompanyName":"Bubblemix", "CompanyId":"82c9ed86-3e81-4a64-8d5e-d4c38f730a21"
                new Employee
                {
                    EmployeeId = Guid.Parse("41ea7095-5f5c-46b3-a202-95387ae9ee1f"),
                    FirstName = "Adela",
                    LastName = "O' Kelleher",
                    ThirdName = "Bootherstone",
                    TIN = "425734037447",
                    CompanyId = Guid.Parse("82c9ed86-3e81-4a64-8d5e-d4c38f730a21")
                },new Employee
                {
                    EmployeeId = Guid.Parse("5c4ab3a9-507f-44bb-a713-443772d1f87d"),
                    FirstName = "Matthew",
                    LastName = "Branche",
                    ThirdName = "Bolitho",
                    TIN = "717832677362",
                    CompanyId = Guid.Parse("82c9ed86-3e81-4a64-8d5e-d4c38f730a21")
                },new Employee
                {
                    EmployeeId = Guid.Parse("f04350bf-e8a4-442f-a0c3-de35e4b00bd7"),
                    FirstName = "Jerad",
                    LastName = "Keddy",
                    ThirdName = "Fydoe",
                    TIN = "647010168828",
                    CompanyId = Guid.Parse("82c9ed86-3e81-4a64-8d5e-d4c38f730a21")
                },
                //"CompanyName":"Dabfeed", "CompanyId":"49f65196-72c2-4709-bc31-265af947edd9"
                new Employee
                {
                    EmployeeId = Guid.Parse("7dc16bc0-4fe6-47ea-bf23-aa457e98f39d"),
                    FirstName = "Jeanie",
                    LastName = "Bunnell",
                    ThirdName = "Lymbourne",
                    TIN = "600096131540",
                    CompanyId = Guid.Parse("49f65196-72c2-4709-bc31-265af947edd9")
                },new Employee
                {
                    EmployeeId = Guid.Parse("05ade310-8e33-49c9-a04d-7492baf19ab7"),
                    FirstName = "Alexia",
                    LastName = "Peirpoint",
                    ThirdName = "Boatwright",
                    TIN = "505918071034",
                    CompanyId = Guid.Parse("49f65196-72c2-4709-bc31-265af947edd9")
                },new Employee
                {
                    EmployeeId = Guid.Parse("0404a9a0-8e09-4a6e-8a8a-1c782548f79f"),
                    FirstName = "Eberto",
                    LastName = "Jefferson",
                    ThirdName = "Hedman",
                    TIN = "648842096584",
                    CompanyId = Guid.Parse("49f65196-72c2-4709-bc31-265af947edd9")
                },
                //"CompanyName":"Feedspan", "CompanyId":"ffb62ce2-a867-4b47-903a-f377cfd571b6"
                new Employee
                {
                    EmployeeId = Guid.Parse("0404a9a0-8e09-4a6e-8a8a-1c782548f79f"),
                    FirstName = "Duncan",
                    LastName = "Shayler",
                    ThirdName = "Hefner",
                    TIN = "103324972519",
                    CompanyId = Guid.Parse("ffb62ce2-a867-4b47-903a-f377cfd571b6")
                },
                new Employee
                {
                    EmployeeId = Guid.Parse("a3c9d9e0-7c14-409c-9d65-b7a2097f6ff6"),
                    FirstName = "Johnny",
                    LastName = "Triggol",
                    ThirdName = "Jancik",
                    TIN = "400744478611",
                    CompanyId = Guid.Parse("ffb62ce2-a867-4b47-903a-f377cfd571b6")
                },
                new Employee
                {
                    EmployeeId = Guid.Parse("6bbd05ce-ea09-448b-9c2e-1f9022f58586"),
                    FirstName = "Penny",
                    LastName = "Beddard",
                    ThirdName = "Golden",
                    TIN = "233052618053",
                    CompanyId = Guid.Parse("ffb62ce2-a867-4b47-903a-f377cfd571b6")
                },
                //"CompanyName":"Trilith", "CompanyId":"2ff63a86-275a-4f19-86db-59e0a3a2b5fd"
                new Employee
                {
                    EmployeeId = Guid.Parse("fc26a78a-0893-4f14-989c-f8e9c32d22ee"),
                    FirstName = "Adi",
                    LastName = "Nials",
                    ThirdName = "Colston",
                    TIN = "632889318739",
                    CompanyId = Guid.Parse("2ff63a86-275a-4f19-86db-59e0a3a2b5fd")
                },new Employee
                {
                    EmployeeId = Guid.Parse("5abfe48d-eaba-4ca0-8f5d-9774668c8d8a"),
                    FirstName = "Staffard",
                    LastName = "Stanbury",
                    ThirdName = "Lamping",
                    TIN = "511590272277",
                    CompanyId = Guid.Parse("2ff63a86-275a-4f19-86db-59e0a3a2b5fd")
                },new Employee
                {
                    EmployeeId = Guid.Parse("c4f12dfa-7054-4824-b419-5ffe65bdb7e6"),
                    FirstName = "Consuela",
                    LastName = "Grewcock",
                    ThirdName = "Padrick",
                    TIN = "123153161701",
                    CompanyId = Guid.Parse("2ff63a86-275a-4f19-86db-59e0a3a2b5fd")
                },
                //"CompanyName":"Kayveo", "CompanyId":"76703cae-5aa2-4ee4-8109-a1dacbed14ed"
                new Employee
                {
                    EmployeeId = Guid.Parse("26074cb9-3373-4738-97d3-6db965bed2bf"),
                    FirstName = "Lloyd",
                    LastName = "Tacey",
                    ThirdName = "Yoselevitch",
                    TIN = "754068727707",
                    CompanyId = Guid.Parse("76703cae-5aa2-4ee4-8109-a1dacbed14ed")
                },new Employee
                {
                    EmployeeId = Guid.Parse("f2bbff61-50df-4de3-a7a9-38ed7de29cb8"),
                    FirstName = "Myrta",
                    LastName = "Mabon",
                    ThirdName = "Boch",
                    TIN = "451205635548",
                    CompanyId = Guid.Parse("76703cae-5aa2-4ee4-8109-a1dacbed14ed")
                },new Employee
                {
                    EmployeeId = Guid.Parse("50660448-9d9a-4452-ad63-2ac027750554"),
                    FirstName = "Jeffie",
                    LastName = "Mogenot",
                    ThirdName = "Heggison",
                    TIN = "363231818337",
                    CompanyId = Guid.Parse("76703cae-5aa2-4ee4-8109-a1dacbed14ed")
                },
            };

            context.Employees.AddOrUpdate(defaultEmployees);
        }
    }
}
