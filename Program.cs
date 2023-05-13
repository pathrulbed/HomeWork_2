class Program
{
    static bool IsValidSequence(string halfDNASequence)
    {
	    foreach(char nucleotide in halfDNASequence)
	    {
    	    if(!"ATCG".Contains(nucleotide))
    	    {
            	return false;
    	    }
	    }
	    return true;
    }
    static string ReplicateSeqeunce(string halfDNASequence)
    {
	    string result = "";
	    foreach(char nucleotide in halfDNASequence)
	    {
        	result += "TAGC"["ATCG".IndexOf(nucleotide)];
	    }
	    return result;
    }

    static void Main(string[] args)
    {
        bool IsRun = true;
        bool IsSequence = true;
        bool IsReplicated =true;
        string? halfDNASequence;
        Console.WriteLine("Input half DNA sequence");
        
        while (IsRun)
        {
            Console.Write("Current half DNA sequence :");
            halfDNASequence = Console.ReadLine();
            if (IsValidSequence(halfDNASequence) == true)
            {
                Console.Write("Do you want to replicate it ? (Y/N) :");
                while (IsReplicated)
                {
                    string? choose = Console.ReadLine();
                    switch(choose)
                    {
                        case "Y":
                        Console.Write("Replicated half DNA sequence : ");
                        Console.WriteLine(ReplicateSeqeunce(halfDNASequence));
                        IsReplicated = false;
                        break;

                        case "N":
                        IsReplicated = false;
                        break;

                        default :
                        Console.WriteLine("Please input Y or N.");
                        break;
                    }

                }
            }

            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");   
            }
            IsSequence = true;
            Console.Write("Do you want to process another sequence? (Y/N) : ");
            while (IsSequence)
                {
                    string? choose = Console.ReadLine();
                    switch(choose)
                    {
                        case "Y":
                        IsSequence = false;
                        IsReplicated = true;
                        break;

                        case "N":
                        IsSequence = false;
                        IsRun = false;
                        break;

                        default :
                        Console.WriteLine("Please input Y or N.");
                        break;
                    }

                }
        }
        
        
    }
}
