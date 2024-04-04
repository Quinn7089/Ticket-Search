string file = "ticketData.txt";
string EnhancementFile = "EnhancementData.txt";
string taskFile = "taskData.txt";
string resp;
string choice;


do
{
    Console.WriteLine("1) Read Data from file.");
    Console.WriteLine("2) Create Ticket.csv");
    Console.WriteLine("3) Create Enhancement.csv");
    Console.WriteLine("4) Create Task.csv");
    Console.WriteLine("5) Search Ticket");
    Console.WriteLine("Enter any other key to exit");


    choice = Console.ReadLine();


    if (choice == "1")
    {
        Console.WriteLine("Choose the ticket you want to view");
        Console.WriteLine("1) View Ticket");
        Console.WriteLine("2) View Enhancement");
        Console.WriteLine("3) View Task");

        resp = Console.ReadLine();


        if (resp == "1")
        {
            if (File.Exists(file))
            {

                StreamReader sr = new StreamReader(file);

                while (!sr.EndOfStream)
                {

                    string newPerson = sr.ReadLine();

                    Console.WriteLine(newPerson);

                }
                sr.Close();
            }
        }
        if (resp == "2")
        {
            if (File.Exists(EnhancementFile))
            {

                StreamReader sr = new StreamReader(EnhancementFile);

                while (!sr.EndOfStream)
                {

                    string newTicket = sr.ReadLine();

                    Console.WriteLine(newTicket);

                }
                sr.Close();
            }
        }
        if (resp == "3")
        {
            if (File.Exists(taskFile))
            {

                StreamReader sr = new StreamReader(taskFile);

                while (!sr.EndOfStream)
                {

                    string newTask = sr.ReadLine();

                    Console.WriteLine(newTask);

                }
                sr.Close();
            }



        }
    }
    if (choice == "2")
    {



        for (int i = 0; i < 7; i++)
        {

            Console.WriteLine("Enter Ticket (Y/N)?");

            resp = Console.ReadLine();

            if (resp != "Y") { break; }

            StreamWriter sw = new StreamWriter(file);

            Console.WriteLine("Enter ticket ID:");

            string ticketID = Console.ReadLine();

            Console.WriteLine("Enter summary:");

            string summary = Console.ReadLine();

            Console.WriteLine("Enter status:");

            string status = Console.ReadLine();

            Console.WriteLine("Enter priority:");

            string priority = Console.ReadLine();

            Console.WriteLine("Enter submitter:");

            string submitter = Console.ReadLine();

            Console.WriteLine("Enter assigend:");

            string assigend = Console.ReadLine();

            Console.WriteLine("Enter watching:");

            string watching = Console.ReadLine();

            sw.WriteLine(ticketID + ", " + summary + ", " + status + ", " + priority + ", " +
            submitter + ", " + assigend + ", " + watching);
            sw.Close();
        }

    }
    if (choice == "3")
    {

        for (int i = 0; i < 7; i++)
        {

            Console.WriteLine("Enter Enhancement (Y/N)?");

            resp = Console.ReadLine();

            if (resp != "Y") { break; }

            StreamWriter sw = new StreamWriter(EnhancementFile);

            Console.WriteLine("Enter ticket ID:");

            string ticketID = Console.ReadLine();

            Console.WriteLine("Enter summary:");

            string summary = Console.ReadLine();

            Console.WriteLine("Enter status:");

            string status = Console.ReadLine();

            Console.WriteLine("Enter priority:");

            string priority = Console.ReadLine();

            Console.WriteLine("Enter submitter:");

            string submitter = Console.ReadLine();

            Console.WriteLine("Enter assigend:");

            string assigned = Console.ReadLine();

            Console.WriteLine("Enter watching:");

            string watching = Console.ReadLine();

            Console.WriteLine("Enter software:");

            string software = Console.ReadLine();

            Console.WriteLine("Enter cost:");

            string cost = Console.ReadLine();

            Console.WriteLine("Enter reason:");

            string reason = Console.ReadLine();

            Console.WriteLine("Enter estimate:");

            string estimate = Console.ReadLine();

            sw.WriteLine(ticketID + ", " + summary + ", " + status + ", " + priority + ", "
             + submitter + ", " + assigned + ", " + watching + ", " + software + ", " +
             cost + ", " + reason + ", " + estimate);

            sw.Close();
        }

    }
    if (choice == "4")
    {


        for (int i = 0; i < 7; i++)
        {

            Console.WriteLine("Enter Task (Y/N)?");

            resp = Console.ReadLine();

            if (resp != "Y") { break; }

            StreamWriter sw = new StreamWriter(taskFile);

            Console.WriteLine("Enter ticket ID:");

            string ticketID = Console.ReadLine();

            Console.WriteLine("Enter summary:");

            string summary = Console.ReadLine();

            Console.WriteLine("Enter status:");

            string status = Console.ReadLine();

            Console.WriteLine("Enter priority:");

            string priority = Console.ReadLine();

            Console.WriteLine("Enter submitter:");

            string submitter = Console.ReadLine();

            Console.WriteLine("Enter assigend:");

            string assigned = Console.ReadLine();

            Console.WriteLine("Enter watching:");

            string watching = Console.ReadLine();

            Console.WriteLine("Enter project name:");

            string name = Console.ReadLine();

            Console.WriteLine("Enter due date:");

            string dueDate = Console.ReadLine();

            sw.WriteLine(ticketID + ", " + summary + ", " + status + ", " + priority + ", " + submitter
            + ", " + assigned + ", " + watching + ", " + name + ", " + dueDate);
            sw.Close();
        }
    }



} while (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5");






public class TicketFile
{

    public string filePath { get; set; }

    public string enhancmentPath { get; set; }

    public List<Ticket> tickets { get; set; }
    public List<Task> tasks { get; set; }

    public List<Enhancment> enhancments { get; set; }

    public TicketFile(string ticketFile, string EnhancementFile, string taskFile)
    {

        filePath = ticketFile;
        tickets = new List<Ticket>();
        // enhancmentPath = EnhancementFile;
        enhancments = new List<Enhancment>();
        tasks = new List<Task>();
        try
        {
            StreamReader sr = new StreamReader(filePath);
            while (!sr.EndOfStream)
            {

                string ticketData = sr.ReadLine();

                string[] ticketDataArray = ticketData.Split(",");

                Ticket newTicket = new Ticket(ticketDataArray[0], ticketDataArray[1], ticketDataArray[2], ticketDataArray[3], ticketDataArray[4], ticketDataArray[5], ticketDataArray[6]);

                tickets.Add(newTicket);

            }
        }
        catch
        {

        }
    }











    public class Ticket
    {


        public Ticket(string ticketId, string summary, string status, string priority, string submitter, string assigend, string watching)
        {
            TicketID = ticketId;
            Summary = summary;
            Status = status;
            Priority = priority;
            Submitter = submitter;
            Assigend = assigend;
            Watching = watching;
        }

        public string TicketID { get; set; }

        public string Summary { get; set; }

        public string Status { get; set; }

        public string Priority { get; set; }

        public string Submitter { get; set; }

        public string Assigend { get; set; }

        public string Watching { get; set; }

        public string Software { get; set; }

        public string Cost { get; set; }

        public string estimate { get; set; }


    }

    public class Enhancment : Ticket
    {

        public Enhancment(string ticketId, string summary, string status, string priority, string submitter, string assigend, string watching, string software, string cost, string estimate) : base(ticketId, summary, status, priority, submitter, assigend, watching)
        {

            TicketID = ticketId;
            Summary = summary;
            Status = status;
            Priority = priority;
            Submitter = submitter;
            Assigend = assigend;
            Watching = watching;
            Software = software;
            Cost = cost;
            Estimate = estimate;

        }



        public string Software { get; set; }

        public string Cost { get; set; }

        public string Estimate { get; set; }




    }




    public class Task : Ticket
    {


        public Task(string ticketId, string summary, string status, string priority, string submitter, string assigend, string watching, string name, string dueDate) : base(ticketId, summary, status, priority, submitter, assigend, watching)
        {
            TicketID = ticketId;
            Summary = summary;
            Status = status;
            Priority = priority;
            Submitter = submitter;
            Assigend = assigend;
            Watching = watching;
            Name = name;
            DueDate = dueDate;
        }

        public string Name { get; set; }
        public string DueDate { get; set; }




    }