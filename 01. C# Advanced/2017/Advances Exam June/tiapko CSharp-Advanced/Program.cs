using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdvancedExam_25June2017
{
    class Department
    {

        public Department()
        {
            this.Doctors = new Dictionary<string, List<string>>();
            this.Rooms = new List<string>();
        }
        public Dictionary<string, List<string>> Doctors { get; set; }
        public List<string> Rooms { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var hospital = new Dictionary<string, Department>();
            while (input != "Output")
            {
                var data = Regex.Match(input, @"^(.*?) ((.*?) (.*?)) (.*?)$");

                var department = data.Groups[1].ToString();
                var doctor = data.Groups[2].ToString();
                var patient = data.Groups[5].ToString();

                if (!hospital.ContainsKey(department))
                {
                    hospital.Add(department, new Department());
                }

                if (!hospital[department].Doctors.ContainsKey(doctor))
                {
                    hospital[department].Doctors.Add(doctor, new List<string>());
                }

                if (hospital[department].Rooms.Count < 60)
                {
                    // add to hospital rooms
                    hospital[department].Rooms.Add(patient);
                    // add to doctors patients
                    hospital[department].Doctors[doctor].Add(patient);
                }

                input = Console.ReadLine();
            }
            input = Console.ReadLine();

            while (input != "End")
            {
                var data = input.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (data.Length == 2)
                {
                    // doctor or dept+room
                    int room = 0;
                    int.TryParse(data[1], out room);

                    if (room > 0)
                    {
                        // dept+room
                        var dept = data[0];

                        // show room data

                        if (hospital[dept].Rooms.Count > ((room - 1) * 3))
                        {
                            var patientsInRoom = hospital[dept].Rooms.Skip((room - 1) * 3).Take(3);
                            Console.WriteLine(string.Join("\n", patientsInRoom.OrderBy(x => x)));
                        }

                    }
                    else
                    {
                        var doctor = input.Trim();
                        var patients = new List<string>();
                        foreach (var dept in hospital)
                        {
                            // foreach dept if doctor exists add the patients
                            if (dept.Value.Doctors.ContainsKey(doctor))
                            {
                                patients.AddRange(dept.Value.Doctors[doctor]);
                            }
                        }

                        Console.WriteLine(string.Join("\n", patients.OrderBy(x => x)));
                    }
                }
                else
                {
                    // department

                    var dept = data[0];
                    Console.WriteLine(string.Join("\n", hospital[dept].Rooms));
                }
                input = Console.ReadLine();
            }
        }
    }
}