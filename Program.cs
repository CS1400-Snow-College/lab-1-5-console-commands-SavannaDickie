// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
Console.Clear();

Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,0); //(Top row 0)
Console.WriteLine("                                       ");//36+3//
 //first row red middle
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(12,1);
Console.WriteLine("                  ");
//first row blue left
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,1);
Console.WriteLine("            ");
//first row blue right
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(30,1);
Console.WriteLine("         ");
//second row blue left
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,2);
Console.WriteLine("         ");
//second row red 
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(9,2);
Console.WriteLine("                           ");
//second row blue right
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(36,2);
Console.WriteLine("   ");
//third row blue left
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,3);
Console.WriteLine("         ");
//third row skin middle
Console.BackgroundColor = ConsoleColor.White;
Console.SetCursorPosition(18,3);
Console.WriteLine("      ");
//third row skin right
Console.BackgroundColor = ConsoleColor.White;
Console.SetCursorPosition(27,3);
Console.WriteLine("   ");
//Third row blue right
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(30,3);
Console.WriteLine("         ");
//fourth row blue left
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,4);
Console.WriteLine("      ");
//Fourth row skin left
Console.BackgroundColor = ConsoleColor.White;
Console.SetCursorPosition(9,4);
Console.WriteLine("   ");
//Fourth row skin middle
Console.BackgroundColor = ConsoleColor.White;
Console.SetCursorPosition(15,4);
Console.WriteLine("         ");
//Fourth row skin right
Console.BackgroundColor = ConsoleColor.White;
Console.SetCursorPosition(27,4);
Console.WriteLine("         ");
//Fourth row blue right
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(36,4);
Console.WriteLine("   ");
//Fifth row blue left
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,5);
Console.WriteLine("      ");
//Fifth skin right
Console.BackgroundColor = ConsoleColor.White;
Console.SetCursorPosition(9,5);
Console.WriteLine("   ");
//Fifth row skin middle
Console.BackgroundColor = ConsoleColor.White;
Console.SetCursorPosition(18,5);
Console.WriteLine("         ");
//fifth row skin right
Console.BackgroundColor = ConsoleColor.White;
Console.SetCursorPosition(30,5);
Console.WriteLine("        ");
//Fifth row blue right
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(38,5);
Console.WriteLine(" ");
//sixth row blue left
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,6);
Console.WriteLine("      ");
//sixth row skin middle
Console.BackgroundColor = ConsoleColor.White;
Console.SetCursorPosition(12,6);
Console.WriteLine("            ");
//sixth row blur right
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(36,6);
Console.WriteLine("   ");
//seventh row blue left 
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,7);
Console.WriteLine("            ");
//seventh row skin middle
Console.BackgroundColor = ConsoleColor.White;
Console.SetCursorPosition(12,7);
Console.WriteLine("                     ");
//seventh row blue right
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(33,7);
Console.WriteLine("      ");
//eighth row blue left
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,8);
Console.WriteLine("         ");
//eighth row blue shirt left
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.SetCursorPosition(9,8);
Console.WriteLine("      ");
//eighth row red middle
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(15,8);
Console.WriteLine("   ");
//eihth row dark blue middle
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.SetCursorPosition(18,8);
Console.WriteLine("         ");
//eighth row blue right
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(27,8);
Console.WriteLine("            ");
//ninth row blue left
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,9);
Console.WriteLine("      ");
//ninth row blue shirt right
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.SetCursorPosition(6,9);
Console.WriteLine("         ");
//ninth row red left 
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(15,9);
Console.WriteLine("   ");
//ninth row dark blue middle
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.SetCursorPosition(18,9);
Console.WriteLine("      ");
//ninth row red right
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(24,9);
Console.WriteLine("   ");
//ninth row dark blue right
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.SetCursorPosition(27,9);
Console.WriteLine("         ");
//ninth row blue right
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(36,9);
Console.WriteLine("   ");
//tenth row blue left
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,10);
Console.WriteLine("   ");
//tenth row dark blue left
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.SetCursorPosition(3,10);
Console.WriteLine("            ");
//tenth row red left
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(15,10);
Console.WriteLine("   ");
//tenth row dark blue middle
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.SetCursorPosition(18,10);
Console.WriteLine("      ");
//tenth row red right
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(24,10);
Console.WriteLine("   ");
//tenth row dark blue right
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.SetCursorPosition(27,10);
Console.WriteLine("           ");
//tenth blue right
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(38,10);
Console.WriteLine(" ");
//11th row blue left
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,11);
Console.WriteLine("   ");
//11th row skin left
Console.BackgroundColor = ConsoleColor.White;
Console.SetCursorPosition(3,11);
Console.WriteLine("      ");
//11th row blue shirt left
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.SetCursorPosition(9,11);
Console.WriteLine("      ");
//11th row red left
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(15,11);
Console.WriteLine("            ");
//11th row blue shirt right
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.SetCursorPosition(27,11);
Console.WriteLine("      ");
//11th row skin right
Console.BackgroundColor = ConsoleColor.White;
Console.SetCursorPosition(33,11);
Console.WriteLine("     ");
//11th blue right
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(38,11);
Console.WriteLine(" ");
//12th row blue left
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,12);
Console.WriteLine("   ");
//12th row skin left
Console.BackgroundColor = ConsoleColor.White;
Console.SetCursorPosition(3,12);
Console.WriteLine("         ");
//12th row red left
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(12,12);
Console.WriteLine("   ");
//12th row yellow left
Console.BackgroundColor = ConsoleColor.Yellow;
Console.SetCursorPosition(15,12);
Console.WriteLine("   ");
//12th row red middle
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(18,12);
Console.WriteLine("      ");
//12th row yellow right
Console.BackgroundColor = ConsoleColor.Yellow;
Console.SetCursorPosition(24,12);
Console.WriteLine("   ");
//12th row red right
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(27,12);
Console.WriteLine("   ");
//12th row skin right
Console.BackgroundColor = ConsoleColor.White;
Console.SetCursorPosition(30,12);
Console.WriteLine("        ");
//12th blue right
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(38,12);
Console.WriteLine(" ");
//13th row blue left
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,13);
Console.WriteLine("   ");
//13th row skin left
Console.BackgroundColor = ConsoleColor.White;
Console.SetCursorPosition(3,13);
Console.WriteLine("      ");
//13th row red middle
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(9,13);
Console.WriteLine("                        ");
//13th row skin right
Console.BackgroundColor = ConsoleColor.White;
Console.SetCursorPosition(33,13);
Console.WriteLine("     ");
//13th blue right
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(38,13);
Console.WriteLine(" ");
//14th row blue left
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,14);
Console.WriteLine("         ");
//14th row red middle
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(9,14);
Console.WriteLine("         ");

//14th row blue left
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,14);
Console.WriteLine("         ");
//14th row red middle
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(9,14);
Console.WriteLine("         ");
//14th row blue left
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(18,14);
Console.WriteLine("      ");
//14th row red middle
Console.BackgroundColor = ConsoleColor.Red;
Console.SetCursorPosition(24,14);
Console.WriteLine("         ");
//14th row blue left
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(33,14);
Console.WriteLine("      ");
//15th row blue left
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,15);
Console.WriteLine("      ");
//15th row green left
Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.SetCursorPosition(6,15);
Console.WriteLine("         ");
//15th row blue middle
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(15,15);
Console.WriteLine("         ");
//15th row red right
Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.SetCursorPosition(24,15);
Console.WriteLine("         ");
//15th row blue left
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(33,15);
Console.WriteLine("      ");

//16th row blue left
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,16);
Console.WriteLine("   ");
//16th row green left
Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.SetCursorPosition(3,16);
Console.WriteLine("            ");
//16th row blue middle
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(15,16);
Console.WriteLine("         ");
//16th row green right
Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.SetCursorPosition(24,16);
Console.WriteLine("            ");
//16th row blue left
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(36,16);
Console.WriteLine("   ");
//17th row blue
Console.BackgroundColor = ConsoleColor.Blue;
Console.SetCursorPosition(0,17); 
Console.WriteLine("                                       ");