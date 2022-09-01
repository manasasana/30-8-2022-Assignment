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
                    books = "no such subject found";
                    break;
            }
            return books;
        }

        public string Historybooks()
        {
            return $"History 1 \nHistory 2 \nHistory 3";
        }

        public string Mathsbooks()
        {
            return $"Maths 1 \nMaths 2 \nMaths 3";
        }

        public string Computerbooks()
        {
            return $"Computer 1 \nComputer 2 \nComputer 3";
        }
    }
}
