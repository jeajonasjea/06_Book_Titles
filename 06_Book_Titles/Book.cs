using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 using System.Threading.Tasks;  
 
 namespace _06_Book_Titles
{ 
 	class Book
 	{ 
    private string title; 
    public string Title
                { 
            get
           {
                return title;
            } 
            set
{
    string[] skiplist = { "the", "a", "an", "and", "over", "in", "of" };
    string[] words = value.Split(' ');
    string newSentence = "";
    bool first = true;
    foreach (string word in words)
                    {
if (first || !skiplist.Contains(word))
{
newSentence += char.ToUpper(word[0]) + word.Substring(1) + " ";
}
else
{
newSentence += word + " ";
}
first = false;
}
                      newSentence = newSentence.Trim();
                      this.title = newSentence;
                  } 
 		} 
 		 
 	} 
 } 


