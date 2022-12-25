using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseFirstApproachEntities db = new DatabaseFirstApproachEntities();
            AREA AreaObj = new AREA();
            Console.WriteLine("1:New Record \n 2:Display \n 3: Update Record \n 4:DeleteRecord \n 5: Exit");
            Console.WriteLine("Enter the number");
            int opt = Convert.ToInt32(Console.ReadLine());


            switch (opt)
            {
                case 1: // add new record
                    Console.WriteLine("Enter Area Name,CityID and Pincode");
                    AreaObj.AreaName = Console.ReadLine();
                    AreaObj.CityID = Convert.ToInt32(Console.ReadLine());
                    db.AREAS.Add(AreaObj);
                    db.SaveChanges();
                    break;
                case 2: // read all record 
                    foreach(AREA a in db.AREAS)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", a.AreaId, a.AreaName, a.CityID, a.CITy.CityName);
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter ID to update");
                    int id = Convert.ToInt32(Console.ReadLine());
                    AreaObj = db.AREAS.Find(id);
                    if(AreaObj == null)
                    {
                        Console.WriteLine("The object is not found");
                    }
                    else
                    {
                        Console.WriteLine("Enter Area Name,CityID for modification ");
                        AreaObj.AreaName = Console.ReadLine();
                        AreaObj.CityID = Convert.ToInt32(Console.ReadLine());
                        db.SaveChanges();
                    }
                    break;
                case 4:
                    Console.WriteLine("Enter ID to delete");
                    int id2 = Convert.ToInt32(Console.ReadLine());
                    AreaObj = db.AREAS.Find(id2);
                    if (AreaObj == null)
                    {
                        Console.WriteLine("The object is not found");
                    }
                    else
                    {
                        db.AREAS.Remove(AreaObj);
                        db.SaveChanges();
                    }
                    break;
                case 5:
                    break;
            }

        }
    }
}
