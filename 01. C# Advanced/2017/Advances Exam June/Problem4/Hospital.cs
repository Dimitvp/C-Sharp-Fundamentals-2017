using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Hospital
    {
        static void Main()
        {
                                                     
            var departmentsRoomsPatients = new Dictionary<string, Dictionary<int, List<string>>>();
            var doctorsPatients = new Dictionary<string, List<string>>();
            var doctor = string.Empty;
            var department = string.Empty;
            var patient = string.Empty;
            
            var room = 0;


            var inputLine = string.Empty;
            while ((inputLine = Console.ReadLine()) != "Output")
            {
                var tokens = inputLine.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                department = tokens[0];
                doctor = tokens[1] + " " + tokens[2];
                patient = tokens[3];

                if (!doctorsPatients.ContainsKey(doctor))
                {
                    doctorsPatients.Add(doctor, new List<string>() {patient});
                }
                else if (!doctorsPatients[doctor].Contains(patient))
                {
                    doctorsPatients[doctor].Add(patient);
                }
                //*************************************
               
                
                if (!departmentsRoomsPatients.ContainsKey(department))
                {
                    room = 1;
                    
                    departmentsRoomsPatients.Add(department, new Dictionary<int, List<string>>() { {room, new List<string>() {patient} } });
                    
                }
                else if (departmentsRoomsPatients[department].Count < 20 && departmentsRoomsPatients[department].ContainsKey(room))
                {
                    if (departmentsRoomsPatients[department][room]. <= 3)
                    {
                        departmentsRoomsPatients[department][room].Add(patient);
                       
                    }
                    else
                    {
                        room =  + 1;
                        departmentsRoomsPatients[department] = new Dictionary<int, List<string>>() { { room, new List<string>() {patient} } };
                        
                    }
                }
                else
                {
                    continue;
                }

            }

            while ((inputLine = Console.ReadLine()) != "End")
            {
                var commands = inputLine.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var roomN = 0;

                if (commands.Length == 1)
                {
                    var departmentName = commands[0];
                    if (departmentsRoomsPatients.ContainsKey(departmentName))
                    {
                        foreach (var dep in departmentsRoomsPatients)
                        {
                            if (departmentName == dep.Key)
                            {
                                foreach (var r in dep.Value)
                                {
                                    foreach (var pa in r.Value)
                                    {
                                        Console.WriteLine(pa);
                                    }
                                }
                            }
                        }

                    }
                    else
                    {
                        continue;
                    }

                }
                else if (int.TryParse(commands[1], out roomN))
                {
                    
                    var departmentName = commands[0];
                    roomN = int.Parse(commands[1]);
                    if (departmentsRoomsPatients.ContainsKey(departmentName))
                    {
                        foreach (var dep in departmentsRoomsPatients)
                        {
                            if (departmentName == dep.Key)
                            {
                                foreach (var r in dep.Value.Where(r => r.Key == roomN))
                                {
                                    foreach (var pa in r.Value.OrderBy(p => p))
                                    {
                                        Console.WriteLine(pa);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                   
                }
                else
                {
                    var docName = commands[0] + " " + commands[1];
                    if (doctorsPatients.ContainsKey(docName))
                    {
                        foreach (var doc in doctorsPatients.Where(d => d.Key == docName))
                        {
                            foreach (var pa in doc.Value.OrderBy(p => p))
                            {
                                Console.WriteLine(pa);
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                         
                }
            }
        }
    }
}
