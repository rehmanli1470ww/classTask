namespace ConsoleApp3.Xestexana
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Pediatr.doctors.Add(new Doctor("Mehemmed","Hemzeyev",12));
            Pediatr.doctors.Add(new Doctor("Eli","Hemzeyev",10));
            Pediatr.doctors.Add(new Doctor("Fariz","Osmanov",9));
            Stamatoloq.doctors.Add(new Doctor("Rubail","Rehmanli",8));
            Stamatoloq.doctors.Add(new Doctor("Pervin", "Nebiyev", 9));
            Travmatoloq.doctors.Add(new Doctor("Aliyev","Isa",6));
            Travmatoloq.doctors.Add(new Doctor("Aliyev","Isa",6));
            Travmatoloq.doctors.Add(new Doctor("Aliyev","Isa",6));
            

        }
    }
}