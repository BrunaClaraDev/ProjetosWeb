using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private readonly SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Departament.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; //DB has been seeded
            }

            Departament d1 = new Departament { Name = "Computers" };
            Departament d2 = new Departament { Name = "Electronics" };
            Departament d3 = new Departament { Name = "Fashion" };
            Departament d4 = new Departament { Name = "Books" };

            Seller s1 = new Seller { Name = "Bob Brown", Email = "bob@gmail.com", BirthDate = new DateTime(1998, 4, 21), BaseSalary = 1000.0, Departament = d1 };
            Seller s2 = new Seller { Name = "Maria Green", Email = "maria@gmail.com", BirthDate = new DateTime(1979, 12, 31), BaseSalary = 3500.0, Departament = d2 };
            Seller s3 = new Seller { Name = "Alex Grey", Email = "alex@gmail.com", BirthDate = new DateTime(1988, 1, 15), BaseSalary = 2200.0, Departament = d1 };
            Seller s4 = new Seller { Name = "Martha Red", Email = "martha@gmail.com", BirthDate = new DateTime(1993, 11, 30), BaseSalary = 3000.0, Departament = d4 };
            Seller s5 = new Seller { Name = "Donald Blue", Email = "donald@gmail.com", BirthDate = new DateTime(2000, 1, 9), BaseSalary = 4000.0, Departament = d3 };
            Seller s6 = new Seller { Name = "Alex Pink", Email = "bob@gmail.com", BirthDate = new DateTime(1997, 3, 4), BaseSalary = 3000.0, Departament = d2 };

            SalesRecord r1 = new SalesRecord { Date = new DateTime(2022, 04, 25), Amount = 11000, Status = SaleStatus.Billed, Seller = s1 };
            SalesRecord r2 = new SalesRecord { Date = new DateTime(2022, 04, 4), Amount = 7000, Status = SaleStatus.Billed, Seller = s5 };
            SalesRecord r3 = new SalesRecord { Date = new DateTime(2022, 04, 13), Amount = 4000, Status = SaleStatus.Canceled, Seller = s4 };
            SalesRecord r4 = new SalesRecord { Date = new DateTime(2022, 04, 1), Amount = 8000, Status = SaleStatus.Billed, Seller = s1 };
            SalesRecord r5 = new SalesRecord { Date = new DateTime(2022, 04, 21), Amount = 3000, Status = SaleStatus.Billed, Seller = s3 };
            SalesRecord r6 = new SalesRecord { Date = new DateTime(2022, 04, 15), Amount = 2000, Status = SaleStatus.Billed, Seller = s1 };
            SalesRecord r7 = new SalesRecord { Date = new DateTime(2022, 04, 28), Amount = 13000, Status = SaleStatus.Billed, Seller = s2 };
            SalesRecord r8 = new SalesRecord { Date = new DateTime(2022, 04, 11), Amount = 4000, Status = SaleStatus.Billed, Seller = s4 };
            SalesRecord r9 = new SalesRecord { Date = new DateTime(2022, 04, 14), Amount = 11000, Status = SaleStatus.Pending, Seller = s6 };
            SalesRecord r10 = new SalesRecord { Date = new DateTime(2022, 04, 7), Amount = 9000, Status = SaleStatus.Billed, Seller = s6 };
            SalesRecord r11 = new SalesRecord { Date = new DateTime(2022, 04, 13), Amount = 6000, Status = SaleStatus.Billed, Seller = s2 };
            SalesRecord r12 = new SalesRecord { Date = new DateTime(2022, 04, 25), Amount = 7000, Status = SaleStatus.Pending, Seller = s3 };
            SalesRecord r13 = new SalesRecord { Date = new DateTime(2022, 04, 29), Amount = 10000, Status = SaleStatus.Billed, Seller = s4 };
            SalesRecord r14 = new SalesRecord { Date = new DateTime(2022, 04, 4), Amount = 3000, Status = SaleStatus.Billed, Seller = s5 };
            SalesRecord r15 = new SalesRecord { Date = new DateTime(2022, 04, 12), Amount = 4000, Status = SaleStatus.Billed, Seller = s1 };
            SalesRecord r16 = new SalesRecord { Date = new DateTime(2022, 05, 5), Amount = 2000, Status = SaleStatus.Billed, Seller = s4 };
            SalesRecord r17 = new SalesRecord { Date = new DateTime(2022, 05, 1), Amount = 12000, Status = SaleStatus.Billed, Seller = s1 };
            SalesRecord r18 = new SalesRecord { Date = new DateTime(2022, 05, 24), Amount = 6000, Status = SaleStatus.Billed, Seller = s3 };
            SalesRecord r19 = new SalesRecord { Date = new DateTime(2022, 05, 22), Amount = 8000, Status = SaleStatus.Billed, Seller = s5 };
            SalesRecord r20 = new SalesRecord { Date = new DateTime(2022, 05, 15), Amount = 8000, Status = SaleStatus.Billed, Seller = s6 };
            SalesRecord r21 = new SalesRecord { Date = new DateTime(2022, 05, 17), Amount = 9000, Status = SaleStatus.Billed, Seller = s2 };
            SalesRecord r22 = new SalesRecord { Date = new DateTime(2022, 05, 24), Amount = 4000, Status = SaleStatus.Billed, Seller = s4 };
            SalesRecord r23 = new SalesRecord { Date = new DateTime(2022, 05, 19), Amount = 11000, Status = SaleStatus.Canceled, Seller = s2 };
            SalesRecord r24 = new SalesRecord { Date = new DateTime(2022, 05, 12), Amount = 8000, Status = SaleStatus.Billed, Seller = s5 };
            SalesRecord r25 = new SalesRecord { Date = new DateTime(2022, 05, 31), Amount = 7000, Status = SaleStatus.Billed, Seller = s3 };
            SalesRecord r26 = new SalesRecord { Date = new DateTime(2022, 05, 6), Amount = 5000, Status = SaleStatus.Billed, Seller = s4 };
            SalesRecord r27 = new SalesRecord { Date = new DateTime(2022, 05, 13), Amount = 9000, Status = SaleStatus.Pending, Seller = s1 };
            SalesRecord r28 = new SalesRecord { Date = new DateTime(2022, 05, 7), Amount = 4000, Status = SaleStatus.Billed, Seller = s3 };
            SalesRecord r29 = new SalesRecord { Date = new DateTime(2022, 05, 23), Amount = 12000, Status = SaleStatus.Billed, Seller = s5 };
            SalesRecord r30 = new SalesRecord { Date = new DateTime(2022, 05, 12), Amount = 5000, Status = SaleStatus.Billed, Seller = s2 };


            _context.Departament.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            _context.SaveChanges();
        }
    }
}
