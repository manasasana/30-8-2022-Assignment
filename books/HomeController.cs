using Microsoft.AspNetCore.Mvc;

namespace books
{
    public class HomeController : Controller
    {
        string books = "";
        public string display(string subject)
        {


            switch (subject)
            {
                case "History":
                    books = Historybooks();
                    break;
                case "Mathematics":
                    books = Mathsbooks();
                    break;
                case "Computer":
                    books = Computerbooks();
                    break;
                default:
                    books = "invalid";
                    break;
            }
            return books;
        }

        public string Historybooks()
        {
            return $"History1 \nHistory2 \nHistory3";
        }

        public string Mathsbooks()
        {
            return $"Maths1 \nMaths2 \nMaths3";
        }

        public string Computerbooks()
        {
            return $"Computer1 \nComputer2 \nComputer3";
        }
    }
}
