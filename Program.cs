//Manuel Leyva
//10-19-22
//Reverse It
// The user will input numbers or leters and the code will reverse the input the user typed in
//Peer review:

string iChoice = "";

do
{

Console.WriteLine(" All right yall lets play a game call reverse it ");
Console.WriteLine("");
Console.WriteLine("Please Type at Least 2 Numbers or More than 2 letters and press enter");
string sInput = Console.ReadLine();

int nResult = 0;

if (int.TryParse(sInput, out nResult))
{ 
            int Reverse = 0;  
            while(nResult>0)  
            {  
                int remainder = nResult % 10;  
                Reverse = (Reverse * 10) + remainder;  
                nResult = nResult / 10;  
            }  
            Console.WriteLine("Reverse No. is {0}",Reverse);  
            //Console.ReadLine(); 
}
else
{ 
    string reverse = "";  
            int Length = 0;  
            Length = sInput.Length - 1;  
            while(Length>=0)  
            {  
                reverse = reverse + sInput[Length];  
                Length--;  
            }  
            //Displaying the reverse word  
            Console.WriteLine("Reverse word is {0}",reverse);  
            //Console.ReadLine();       
}
do
{
    Console.WriteLine(" Simple question do you wanna play again: Yes or No?");
    iChoice = Console.ReadLine().ToUpper();
    if(iChoice != "Yes" && iChoice != "NO")
    {
        Console.WriteLine(" Bro, thats not yes or no, try again");
    }
}while (iChoice !="YES" && iChoice != "NO");
}while(iChoice == "YES");