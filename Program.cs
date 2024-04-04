



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