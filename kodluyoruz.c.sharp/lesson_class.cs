namespace kodluyoruz.c.sharp
{
    public class lesson_class
    {
        public void example()
        {
            var worker1 = new worker();

            worker1.name = "samet";
            worker1.departman = "yazılım";
            worker1.number = 123;
            worker1.surname = "can";
        }
    }

    public class worker
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int number { get; set; }
        public string departman { get; set; }

        public worker()
        {
            
        }
        public worker(string name, string surname, int number, string departman)
        {
            this.name = name;
            this.departman = departman;
            this.number = number;
            this.surname = surname;
        }
    }
}