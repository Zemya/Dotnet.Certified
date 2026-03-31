
/*Suppose you work for a payment processing company that still supports legacy mainframe systems. Often, those systems 
require data to be input in specific columns. For example, store the Payment ID in columns 1 through 6, the payee's name 
in columns 7 through 30, and the Payment Amount in columns 31 through 40. Also, importantly, the Payment Amount is 
right-aligned.

You're asked to build an application that will convert data in the relational database management system to the legacy 
file format. To ensure that the integration works correctly, the first step is to confirm the file format by giving the 
legacy system maintainers a sample of the output. Later, you build on this work to send hundreds or thousands of 
payments to be processed via an ASCII text file.*/

string paymentId = "769C";
string payeeName = "Contoso";
string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24); 
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
 Console.WriteLine(formattedLine);

