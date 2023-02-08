using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace PBLBINARYSUDOKUFİNAL
{
    class Program
    {
        static void WriteFullLine(string value)
        {

            // Write an entire line to the console with the string.
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(value.PadLeft(Console.WindowTop));     //It ensures that the text we print on a colored background is left aligned. 
                                                                     // Reset the color.
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            

            Console.SetCursorPosition(27, 0);
            WriteFullLine("   New Piece   ");

            Console.SetCursorPosition(54, 0);
            WriteFullLine("   Score:   ");
            int newpiece = 0;



            int counter = 0;                    // It keeps the number of game pieces produced
            int cursorx = 32, cursory = 2;     // position of cursor
            ConsoleKeyInfo cki;               // required for readkey


            double sum = 0;

            int[,] ch = new int[11, 9];
            for (int row = 0; row < 11; row++)
                //In order to write a "." later in our integer array, we assign an empty value such as - 1 for now.
                for (int col = 0; col < 9; col++)
                    ch[row, col] = -1;


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("  ----- ----- ----- ");
            Console.WriteLine(" |     |     |     |");
            Console.WriteLine(" |     |     |     |");
            Console.WriteLine(" |     |     |     |");
            Console.WriteLine("  ----- ----- ----- ");
            Console.WriteLine(" |     |     |     |");
            Console.WriteLine(" |     |     |     |");
            Console.WriteLine(" |     |     |     |");
            Console.WriteLine("  ----- ----- ----- ");
            Console.WriteLine(" |     |     |     |");
            Console.WriteLine(" |     |     |     |");
            Console.WriteLine(" |     |     |     |");
            Console.WriteLine("  ----- ----- ----- ");

            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("  1 2 3 4 5 6 7 8 9 ");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("1\n2\n3\n\n4\n5\n6\n\n7\n8\n9");
            Console.SetCursorPosition(0, 1);
            cursorx = 1;
            cursory = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.SetCursorPosition(cursorx, cursory);
                    Console.WriteLine("+");
                    cursorx = cursorx + 6;

                }
                cursorx = 1;
                cursory = cursory + 4;
            }

            cursorx = 32;
            cursory = 2;

            Random rnd = new Random();
            int choice = rnd.Next(1, 5);     //Assigned values ​​1 for 1 - element, 2 for 2 - element, 3 for 3 - element, 4 for 4 - element


            int form = rnd.Next(1, 3);       //"1" for horizontal shapes and "2" for vertical shapes for 2 - element parts
            int form2 = rnd.Next(1, 7);

            int[,] piece = new int[3, 3];    // new array created for game pieces
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    piece[i, j] = -1;
                }
            }
            int p;
            int p1;
            int p2;
            int p3;


            // Since the 3rd and 7th lines coincide with the hypen in the table, we make the cursor skip there.
            int x = 0;    //the variable we use to understand the horizontal length of the game piece we produce
            int y = 0;    //the variable we use to understand the vertical length of the game piece we produce
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (i == 3 || i == 7)
                    {
                        i++;
                    }
                    Console.SetCursorPosition(2 * j + 2, i + 2);

                    if (ch[i, j] == -1)
                        Console.Write(".");
                    else
                        Console.Write(ch[i, j]);


                }
            }
            //Game pieces are created and assigned into piece array.
            switch (choice)
            {

                case 1:                                           //1-element game pieces      
                    piece[0, 0] = (rnd.Next(0, 2));
                    counter = counter + 1;

                    break;
                case 2:                                           //2-element game pieces
                    p = (rnd.Next(0, 2));
                    p1 = (rnd.Next(0, 2));
                    if (form == 1)
                    {
                        piece[0, 0] = p;
                        piece[0, 1] = p1;
                        counter = counter + 1;
                        x = x + 2;                               //Since the length of the piece we produce is 2, then we increase it by 2 so that the cursor can move correctly.
                    }
                    else
                    {
                        piece[0, 0] = p;
                        piece[1, 0] = p1;
                        counter = counter + 1;
                        y = y + 1;
                    }
                    break;
                case 3:                                          //3-element game pieces
                    p = (rnd.Next(0, 2));
                    p1 = (rnd.Next(0, 2));
                    p2 = (rnd.Next(0, 2));
                    if (form2 == 1)
                    {
                        piece[0, 0] = p;
                        piece[0, 1] = p1;
                        piece[0, 2] = p2;
                        counter = counter + 1;
                        x = x + 4;
                    }
                    else if (form2 == 2)
                    {
                        piece[0, 0] = p;
                        piece[1, 0] = p1;
                        piece[2, 0] = p2;

                        counter = counter + 1;
                        y = y + 2;

                    }
                    else if (form2 == 3)
                    {
                        piece[0, 0] = p;
                        piece[0, 1] = p1;
                        piece[1, 0] = p2;

                        counter = counter + 1;
                        x = x + 2;
                        y = y + 1;
                    }
                    else if (form2 == 4)
                    {
                        piece[0, 0] = p;
                        piece[0, 1] = p1;
                        piece[1, 1] = p2;

                        counter = counter + 1;
                        x = x + 2;
                        y = y + 1;
                    }
                    else if (form2 == 5)
                    {
                        piece[0, 0] = p;
                        piece[1, 0] = p1;
                        piece[1, 1] = p2;

                        counter = counter + 1;
                        x = x + 2;
                        y = y + 1;
                    }
                    else
                    {
                        piece[0, 1] = p;
                        piece[1, 0] = p1;
                        piece[1, 1] = p2;

                        counter = counter + 1;
                        x = x + 2;
                        y = y + 1;
                    }
                    break;
                case 4:                                            //4-element game pieces
                    p = (rnd.Next(0, 2));
                    p1 = (rnd.Next(0, 2));
                    p2 = (rnd.Next(0, 2));
                    p3 = (rnd.Next(0, 2));
                    piece[0, 0] = p;
                    piece[0, 1] = p1;
                    piece[1, 0] = p2;
                    piece[1, 1] = p3;

                    counter = counter + 1;
                    x = x + 2;
                    y = y + 1;
                    break;

            }


            while (true)
            {
                Console.SetCursorPosition(54, 2);
                WriteFullLine("   Piece:" + counter + "   ");


                // Loops created so that the array of pieces can navigate the game board correctly
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {

                        if (i == 1 || i == 2)
                        {
                            if (i == 2)
                            {
                                // The cursor moves between the values ​​2 and 18 in the game board and needs to skip the 3 and 7 values.
                                if ((cursorx >= 2 && cursorx <= 18) && (cursory == 3 || cursory == 7))
                                {
                                    Console.SetCursorPosition(cursorx + 2 * j, cursory + 3);
                                }
                                else if ((cursorx >= 2 && cursorx <= 18) && (cursory == 4 || cursory == 8))
                                {
                                    Console.SetCursorPosition(cursorx + 2 * j, cursory + 3);
                                }
                                else
                                {
                                    Console.SetCursorPosition(cursorx + 2 * j, cursory + i);
                                }
                            }
                            else if (i == 1)
                            {
                                if ((cursorx >= 2 && cursorx <= 18) && (cursory == 4 || cursory == 8))
                                {
                                    Console.SetCursorPosition(cursorx + 2 * j, cursory + 2 * i);
                                }
                                else
                                {
                                    Console.SetCursorPosition(cursorx + 2 * j, cursory + i);
                                }
                            }

                            if (piece[i, j] == 0 || piece[i, j] == 1)
                            {

                                Console.Write(piece[i, j]);
                            }
                            else if (piece[i, j] == -1)
                            {
                                Console.WriteLine("");

                            }

                        }

                        else

                        {
                            Console.SetCursorPosition(cursorx + 2 * j, cursory + i);


                            if (piece[i, j] == 0 || piece[i, j] == 1)
                            {

                                Console.Write(piece[i, j]);
                            }
                            else if (piece[i, j] == -1)
                            {
                                Console.WriteLine("");

                            }

                        }

                    }

                }



                if (Console.KeyAvailable)
                {

                    cki = Console.ReadKey(true);

                    if (cki.Key == ConsoleKey.RightArrow && cursorx < 50)
                    {
                        if (cki.Key == ConsoleKey.RightArrow && cursorx + x < 50 && cursorx + x > 22)
                        {
                            //The expression used to delete the things written on the way from where we created the part to the table.
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.WriteLine("      ");
                            Console.SetCursorPosition(cursorx, cursory + 1);
                            Console.WriteLine("      ");
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.WriteLine("      ");
                            cursorx = cursorx + 2;

                        }
                        else if (cki.Key == ConsoleKey.RightArrow && cursorx + x < 17)
                        {
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.WriteLine(".");
                            cursorx = cursorx + 2;
                        }


                    }

                    if (cki.Key == ConsoleKey.LeftArrow && cursorx > 2)
                    {
                        if (cki.Key == ConsoleKey.LeftArrow && cursorx < 50 && cursorx + x > 18)
                        {

                            Console.SetCursorPosition(cursorx, cursory);
                            Console.WriteLine("      ");
                            Console.SetCursorPosition(cursorx, cursory + 1);
                            Console.WriteLine("      ");
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.WriteLine("      ");
                            cursorx = cursorx - 2;
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.SetCursorPosition(19, 2);
                            Console.WriteLine("|");
                            Console.SetCursorPosition(19, 3);
                            Console.WriteLine("|");
                            Console.SetCursorPosition(19, 4);
                            Console.WriteLine("|");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.WriteLine(".");
                            cursorx = cursorx - 2;
                        }


                    }

                    if (cki.Key == ConsoleKey.UpArrow && cursory > 2 && cursorx < 19)
                    {
                        if (cursory == 6 || cursory == 10)
                        {
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.WriteLine(".");
                            cursory = cursory - 2;
                        }
                        else
                        {
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.WriteLine(".");
                            cursory--;
                        }
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.SetCursorPosition(0, 5);                          //We reprint the deleted places
                        Console.WriteLine("  ----- ----- ----- ");
                        Console.SetCursorPosition(0, 9);
                        Console.WriteLine("  ----- ----- ----- ");
                        int coorx = 1;
                        int coory = 5;
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.SetCursorPosition(coorx, coory);
                                Console.WriteLine("+");
                                coorx = coorx + 6;

                            }
                            coorx = 1;
                            coory = coory + 4;
                        }
                        Console.ResetColor();
                    }
                    if (cki.Key == ConsoleKey.DownArrow && cursory < 12 - y && cursorx < 19 - x)
                    {
                        if (cursory == 4 || cursory == 8)
                        {
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.WriteLine(".");
                            cursory = cursory + 2;
                        }
                        else

                        {
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.WriteLine(".");
                            cursory++;
                        }
                        if (cursory == 3)
                        {

                        }
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.SetCursorPosition(0, 5);
                        Console.WriteLine("  ----- ----- ----- ");
                        Console.SetCursorPosition(0, 9);
                        Console.WriteLine("  ----- ----- ----- ");
                        int coorx = 1;
                        int coory = 5;
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.SetCursorPosition(coorx, coory);
                                Console.WriteLine("+");
                                coorx = coorx + 6;

                            }
                            coorx = 1;
                            coory = coory + 4;
                        }
                        Console.ResetColor();
                    }


                    Console.SetCursorPosition(cursorx, cursory);
                    if (cki.Key == ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(cursorx, cursory);


                        //We throw the values ​​in the pieces into the ch array, which is our main array, if they are filled with 1 or 0
                        newpiece = 0;
                        int control = 0;
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                if (!(piece[i, j] == -1))
                                {

                                    if ((i == 2) && (cursorx >= 2 && cursorx <= 18) && (cursory == 3 || cursory == 7 || cursory == 4 || cursory == 8))
                                    {
                                        if (!(ch[cursory - 2 + 3, (cursorx / 2) - 1 + j] == -1))
                                        {
                                            control++;
                                        }
                                    }
                                    else if (cursorx < 50 && cursorx > 19)
                                    {
                                        control++;
                                    }
                                    else if ((cursorx >= 2 && cursorx <= 18) && (cursory == 4 || cursory == 8))
                                    {
                                        if (!(ch[cursory - 2 + 2 * i, (cursorx / 2) - 1 + j] == -1))
                                        {
                                            control++;
                                        }
                                    }

                                    else
                                    {
                                        if (!(ch[cursory - 2 + i, (cursorx / 2) - 1 + j] == -1))
                                        {
                                            control++;
                                        }
                                    }

                                }
                            }
                        }

                        if (control == 0) // That means array is empty, we can insert the new item.
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                for (int j = 0; j < 3; j++)
                                {
                                    if (!(piece[i, j] == -1))
                                    {
                                        if ((i == 2) && (cursorx >= 2 && cursorx <= 18) && (cursory == 3 || cursory == 7 || cursory == 4 || cursory == 8))
                                        {
                                            ch[cursory - 2 + 3, (cursorx / 2) - 1 + j] = piece[i, j];
                                        }
                                        else if ((cursorx >= 2 && cursorx <= 18) && (cursory == 4 || cursory == 8))
                                        {
                                            ch[cursory - 2 + 2 * i, (cursorx / 2) - 1 + j] = piece[i, j];

                                        }
                                        else
                                        {
                                            ch[cursory - 2 + i, (cursorx / 2) - 1 + j] = piece[i, j];
                                        }

                                        newpiece = 1;
                                    }
                                }
                            }
                        }
                    }

                    if (newpiece == 1)
                    {
                        cursory = 2;
                        cursorx = 32;

                        // Codes that make a beep sound when we insert the piece.
                        for (int i = 0; i < 1; i++)
                        {
                            Console.Beep(270, 200);

                        }
                        for (int j = 0; j < 1; j++)
                        {
                            Console.Beep(330, 200);
                        }

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                piece[i, j] = -1;
                            }
                        }

                        choice = rnd.Next(1, 5);

                        form = rnd.Next(1, 3);
                        form2 = rnd.Next(1, 7);
                        x = 0;
                        y = 0;

                        switch (choice)
                        {

                            case 1:
                                piece[0, 0] = (rnd.Next(0, 2));
                                counter = counter + 1;

                                break;
                            case 2:
                                p = (rnd.Next(0, 2));
                                p1 = (rnd.Next(0, 2));
                                if (form == 1)
                                {
                                    piece[0, 0] = p;
                                    piece[0, 1] = p1;
                                    counter = counter + 1;
                                    x = x + 2;
                                }
                                else
                                {
                                    piece[0, 0] = p;
                                    piece[1, 0] = p1;
                                    counter = counter + 1;
                                    y = y + 1;
                                }
                                break;
                            case 3:
                                p = (rnd.Next(0, 2));
                                p1 = (rnd.Next(0, 2));
                                p2 = (rnd.Next(0, 2));
                                if (form2 == 1)
                                {
                                    piece[0, 0] = p;
                                    piece[0, 1] = p1;
                                    piece[0, 2] = p2;
                                    counter = counter + 1;
                                    x = x + 4;
                                }
                                else if (form2 == 2)
                                {
                                    piece[0, 0] = p;
                                    piece[1, 0] = p1;
                                    piece[2, 0] = p2;

                                    counter = counter + 1;
                                    y = y + 2;

                                }
                                else if (form2 == 3)
                                {
                                    piece[0, 0] = p;
                                    piece[0, 1] = p1;
                                    piece[1, 0] = p2;

                                    counter = counter + 1;
                                    x = x + 2;
                                    y = y + 1;
                                }
                                else if (form2 == 4)
                                {
                                    piece[0, 0] = p;
                                    piece[0, 1] = p1;
                                    piece[1, 1] = p2;

                                    counter = counter + 1;
                                    x = x + 2;
                                    y = y + 1;
                                }
                                else if (form2 == 5)
                                {
                                    piece[0, 0] = p;
                                    piece[1, 0] = p1;
                                    piece[1, 1] = p2;

                                    counter = counter + 1;
                                    x = x + 2;
                                    y = y + 1;
                                }
                                else
                                {
                                    piece[0, 1] = p;
                                    piece[1, 0] = p1;
                                    piece[1, 1] = p2;

                                    counter = counter + 1;
                                    x = x + 2;
                                    y = y + 1;
                                }
                                break;
                            case 4:
                                p = (rnd.Next(0, 2));
                                p1 = (rnd.Next(0, 2));
                                p2 = (rnd.Next(0, 2));
                                p3 = (rnd.Next(0, 2));
                                piece[0, 0] = p;
                                piece[0, 1] = p1;
                                piece[1, 0] = p2;
                                piece[1, 1] = p3;

                                counter = counter + 1;
                                x = x + 2;
                                y = y + 1;
                                break;

                        }
                        newpiece = 0;
                    }

                }

                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (i == 3 || i == 7)
                        {
                            i++;
                        }
                        Console.SetCursorPosition(2 * j + 2, i + 2);

                        if (ch[i, j] == -1)
                            Console.Write(".");
                        else
                            Console.Write(ch[i, j]);


                    }
                }



                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {


                        Console.ForegroundColor = ConsoleColor.DarkRed;


                        if (i == 1 || i == 2)
                        {
                            if (i == 2)
                            {
                                if ((cursorx >= 2 && cursorx <= 18) && (cursory == 3 || cursory == 7))
                                {
                                    Console.SetCursorPosition(cursorx + 2 * j, cursory + 3);
                                }
                                else if ((cursorx >= 2 && cursorx <= 18) && (cursory == 4 || cursory == 8))
                                {
                                    Console.SetCursorPosition(cursorx + 2 * j, cursory + 3);
                                }
                                else
                                {
                                    Console.SetCursorPosition(cursorx + 2 * j, cursory + i);
                                }
                            }
                            else if (i == 1)
                            {
                                if ((cursorx >= 2 && cursorx <= 18) && (cursory == 4 || cursory == 8))
                                {
                                    Console.SetCursorPosition(cursorx + 2 * j, cursory + 2 * i);
                                }
                                else

                                {
                                    Console.SetCursorPosition(cursorx + 2 * j, cursory + i);
                                }
                            }

                            if (piece[i, j] == 0 || piece[i, j] == 1)
                            {

                                Console.Write(piece[i, j]);
                            }
                            else if (piece[i, j] == -1)
                            {
                                Console.WriteLine("");

                            }



                        }

                        else
                        {
                            Console.SetCursorPosition(cursorx + 2 * j, cursory + i);


                            if (piece[i, j] == 0 || piece[i, j] == 1)
                            {

                                Console.Write(piece[i, j]);
                            }
                            else if (piece[i, j] == -1)
                            {
                                Console.WriteLine("");

                            }

                        }

                    }
                    Console.ResetColor();
                }





                Console.SetCursorPosition(0, 0);
                Thread.Sleep(50);

                //the part of checking whether the lines are completely filled
                int cont = 0;
                int count1 = 0;
                int count2 = 0;
                int count3 = 0;
                double binary = 0;
                // 3 different loops were created to skip the 3rd and 7th rows.
                for (int a = 0; a < 3; a++)
                {
                    if ((ch[a, 0] == 1 || ch[a, 0] == 0) && (ch[a, 1] == 1 || ch[a, 1] == 0) && (ch[a, 2] == 1 || ch[a, 2] == 0) && (ch[a, 3] == 1 || ch[a, 3] == 0) && (ch[a, 4] == 1 || ch[a, 4] == 0) && (ch[a, 5] == 1 || ch[a, 5] == 0) && (ch[a, 6] == 1 || ch[a, 6] == 0) && (ch[a, 7] == 1 || ch[a, 7] == 0) && (ch[a, 8] == 1 || ch[a, 8] == 0))
                    {
                        int k = 0;
                        for (int j = 8; j >= 0; j--)
                        {
                            binary += ch[a, j] * Math.Pow(2, k);
                            k++;
                        }
                        cont++;

                        count1++;
                        sum += binary;

                        Console.SetCursorPosition(55, 0);
                        WriteFullLine("   Score:" + cont * sum + "   ");

                        Console.SetCursorPosition(30, 10);
                        WriteFullLine("   Calculations:" + "    ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.SetCursorPosition(30, 12 + a);
                        Console.WriteLine("(" + ch[a, 0] + ch[a, 1] + ch[a, 2] + ch[a, 3] + ch[a, 4] + ch[a, 5] + ch[a, 6] + ch[a, 7] + ch[a, 8] + ")" + "2" + "= " + "(" + binary + ")" + "10");
                        Console.SetCursorPosition(30, 13 + a);
                        Console.WriteLine(cont + "x" + sum + "=" + (cont * sum));

                        Console.ResetColor();
                        for (int i = 0; i < 9; i++)  //Delete the completely filled line and replace "." we are printing
                        {
                            ch[a, i] = -1;

                        }
                    }
                }
                for (int b = 4; b < 7; b++)
                {
                    if ((ch[b, 0] == 1 || ch[b, 0] == 0) && (ch[b, 1] == 1 || ch[b, 1] == 0) && (ch[b, 2] == 1 || ch[b, 2] == 0) && (ch[b, 3] == 1 || ch[b, 3] == 0) && (ch[b, 4] == 1 || ch[b, 4] == 0) && (ch[b, 5] == 1 || ch[b, 5] == 0) && (ch[b, 6] == 1 || ch[b, 6] == 0) && (ch[b, 7] == 1 || ch[b, 7] == 0) && (ch[b, 8] == 1 || ch[b, 8] == 0))
                    {
                        int k = 0;
                        for (int j = 8; j >= 0; j--)
                        {
                            binary += ch[b, j] * Math.Pow(2, k);
                            k++;
                        }
                        cont++;


                        count1++;
                        sum += binary;
                        Console.SetCursorPosition(55, 0);
                        WriteFullLine("   Score:" + cont * sum + "   ");

                        Console.SetCursorPosition(30, 10);
                        WriteFullLine("   Calculations:" + "    ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.SetCursorPosition(30, 8 + b);
                        Console.WriteLine("(" + ch[b, 0] + ch[b, 1] + ch[b, 2] + ch[b, 3] + ch[b, 4] + ch[b, 5] + ch[b, 6] + ch[b, 7] + ch[b, 8] + ")" + "2" + "= " + "(" + binary + ")" + "10");
                        Console.SetCursorPosition(30, 9 + b);
                        Console.WriteLine(cont + "x" + sum + "=" + (cont * sum));

                        Console.ResetColor();

                        for (int i = 0; i < 9; i++)
                        {
                            ch[b, i] = -1;
                        }
                    }
                }
                for (int c = 8; c < 11; c++)
                {
                    if ((ch[c, 0] == 1 || ch[c, 0] == 0) && (ch[c, 1] == 1 || ch[c, 1] == 0) && (ch[c, 2] == 1 || ch[c, 2] == 0) && (ch[c, 3] == 1 || ch[c, 3] == 0) && (ch[c, 4] == 1 || ch[c, 4] == 0) && (ch[c, 5] == 1 || ch[c, 5] == 0) && (ch[c, 6] == 1 || ch[c, 6] == 0) && (ch[c, 7] == 1 || ch[c, 7] == 0) && (ch[c, 8] == 1 || ch[c, 8] == 0))
                    {
                        int k = 0;
                        for (int j = 8; j >= 0; j--)
                        {
                            binary += ch[c, j] * Math.Pow(2, k);
                            k++;
                        }
                        cont++;
                        count1++;
                        sum += binary;
                        Console.SetCursorPosition(55, 0);
                        WriteFullLine("   Score:" + cont * sum + "   ");


                        Console.SetCursorPosition(30, 10);
                        WriteFullLine("   Calculations:" + "    ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.SetCursorPosition(30, 4 + c);
                        Console.WriteLine("(" + ch[c, 0] + ch[c, 1] + ch[c, 2] + ch[c, 3] + ch[c, 4] + ch[c, 5] + ch[c, 6] + ch[c, 7] + ch[c, 8] + ")" + "2" + "= " + "(" + binary + ")" + "10");
                        Console.SetCursorPosition(30, 5 + c);
                        Console.WriteLine(cont + "x" + sum + "=" + (cont * sum));
                        Console.ResetColor();


                        for (int i = 0; i < 9; i++)
                        {
                            ch[c, i] = -1;
                        }
                    }
                }


                // The section where the columns are checked whether they are completely filled or not

                for (int b = 0; b < 9; b++)
                {
                    if ((ch[0, b] == 1 || ch[0, b] == 0) && (ch[1, b] == 1 || ch[1, b] == 0) && (ch[2, b] == 1 || ch[2, b] == 0) && (ch[4, b] == 1 || ch[4, b] == 0) && (ch[5, b] == 1 || ch[5, b] == 0) && (ch[6, b] == 1 || ch[6, b] == 0) && (ch[8, b] == 1 || ch[8, b] == 0) && (ch[9, b] == 1 || ch[9, b] == 0) && (ch[10, b] == 1 || ch[10, b] == 0))
                    {
                        int k = 0;
                        for (int j = 10; j >= 8; j--)
                        {
                            binary += ch[j, b] * Math.Pow(2, k);
                            k++;
                        }

                        for (int j = 6; j >= 4; j--)
                        {
                            binary += ch[j, b] * Math.Pow(2, k);
                            k++;
                        }

                        for (int j = 2; j >= 0; j--)
                        {
                            binary += ch[j, b] * Math.Pow(2, k);
                            k++;
                        }
                        cont++;
                        count2++;
                        sum += binary;
                        Console.SetCursorPosition(55, 0);
                        WriteFullLine("   Score:" + cont * sum + "   ");

                        Console.SetCursorPosition(30, 10);
                        WriteFullLine("   Calculations:" + "    ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.SetCursorPosition(30, 12 + b);
                        Console.WriteLine("(" + ch[0, b] + ch[1, b] + ch[2, b] + ch[4, b] + ch[5, b] + ch[6, b] + ch[8, b] + ch[9, b] + ch[10, b] + ")" + "2" + "= " + "(" + binary + ")" + "10");
                        Console.SetCursorPosition(30, 13 + b);
                        Console.WriteLine(cont + "x" + sum + "=" + (cont * sum));

                        Console.ResetColor();

                        ch[0, b] = -1;
                        ch[1, b] = -1;
                        ch[2, b] = -1;
                        ch[4, b] = -1;
                        ch[5, b] = -1;
                        ch[6, b] = -1;
                        ch[8, b] = -1;
                        ch[9, b] = -1;
                        ch[10, b] = -1;
                    }

                }

                //Blocks control
                int mycounter2 = 0;

                for (int i = 0; i <= 8; i += 4)
                {
                    mycounter2 = 0;
                    for (int j = 0; j < 3; j++)
                    {
                        if ((ch[i, j] == 1 || ch[i, j] == 0) && (ch[i + 1, j] == 1 || ch[i + 1, j] == 0) && (ch[i + 2, j] == 1 || ch[i + 2, j] == 0))
                        {
                            mycounter2++;
                            if (mycounter2 == 3)
                            {
                                int by = 0;
                                int value = 8;

                                for (int l = 0; l < 3; l++)
                                {
                                    binary += (ch[i, by]) * Math.Pow(2, value);
                                    value--;
                                    binary += (ch[i + 1, by]) * Math.Pow(2, value);
                                    value--;
                                    binary += (ch[i + 2, by]) * Math.Pow(2, value);
                                    value--;
                                    by++;
                                }
                                cont++;
                                count3++;
                                sum += binary;
                                Console.SetCursorPosition(55, 0);
                                WriteFullLine("   Score:" + cont * sum + "   ");

                                Console.SetCursorPosition(30, 10);
                                WriteFullLine("   Calculations:" + "    ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.SetCursorPosition(30, 12);

                                for (int b = 0; b < 3; b++)
                                {
                                    Console.SetCursorPosition(30, 12 + b + i);

                                    Console.Write("(" + ch[i, b] + ch[i + 1, b] + ch[i + 2, b] + ")");

                                }
                                Console.SetCursorPosition(36, 13 + i);
                                Console.WriteLine("= (" + binary + ")10");
                                Console.SetCursorPosition(35, 14 + i);
                                Console.WriteLine("2");
                                Console.SetCursorPosition(30, 16 + i);
                                Console.WriteLine(cont + "x" + sum + "=" + (cont * sum));
                                Console.WriteLine();
                                Console.ResetColor();
                                for (int k = 0; k < 3; k++)
                                {
                                    for (int l = i; l < i + 3; l++)
                                    {
                                        ch[l, k] = -1;
                                    }
                                }
                            }
                        }
                    }
                }

                for (int i = 0; i <= 8; i += 4)
                {
                    mycounter2 = 0;
                    for (int j = 3; j < 6; j++)
                    {
                        if ((ch[i, j] == 1 || ch[i, j] == 0) && (ch[i + 1, j] == 1 || ch[i + 1, j] == 0) && (ch[i + 2, j] == 1 || ch[i + 2, j] == 0))
                            mycounter2++;
                        if (mycounter2 == 3)
                        {
                            int by = 3;
                            int value = 8;

                            for (int l = 0; l < 3; l++)
                            {
                                binary += (ch[i, by]) * Math.Pow(2, value);
                                value--;
                                binary += (ch[i + 1, by]) * Math.Pow(2, value);
                                value--;
                                binary += (ch[i + 2, by]) * Math.Pow(2, value);
                                value--;
                                by++;
                            }
                            cont++;
                            count3++;
                            sum += binary;
                            Console.SetCursorPosition(55, 0);
                            WriteFullLine("   Score:" + cont * sum + "   ");
                            Console.SetCursorPosition(30, 10);
                            WriteFullLine("   Calculations:" + "    ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.SetCursorPosition(30, 12);
                            for (int b = 3; b < 6; b++)
                            {
                                Console.SetCursorPosition(30, 9 + b + i);

                                Console.Write("(" + ch[i, b] + ch[i + 1, b] + ch[i + 2, b] + ")");

                            }
                            Console.SetCursorPosition(36, 13 + i);
                            Console.WriteLine("= (" + binary + ")10");
                            Console.SetCursorPosition(35, 14 + i);
                            Console.WriteLine("2");
                            Console.SetCursorPosition(30, 16 + i);
                            Console.WriteLine(cont + "x" + sum + "=" + (cont * sum));


                            for (int k = 3; k < 6; k++)
                            {
                                for (int l = i; l < i + 3; l++)
                                {
                                    ch[l, k] = -1;
                                }
                            }
                        }
                    }
                }

                for (int i = 0; i <= 8; i += 4)
                {
                    mycounter2 = 0;
                    for (int j = 6; j < 9; j++)
                    {
                        if ((ch[i, j] == 1 || ch[i, j] == 0) && (ch[i + 1, j] == 1 || ch[i + 1, j] == 0) && (ch[i + 2, j] == 1 || ch[i + 2, j] == 0))
                            mycounter2++;
                        if (mycounter2 == 3)
                        {
                            int by = 6;
                            int value = 8;

                            for (int l = 0; l < 3; l++)
                            {
                                binary += (ch[i, by]) * Math.Pow(2, value);
                                value--;
                                binary += (ch[i + 1, by]) * Math.Pow(2, value);
                                value--;
                                binary += (ch[i + 2, by]) * Math.Pow(2, value);
                                value--;
                                by++;
                            }
                            cont++;
                            count3++;
                            sum += binary;
                            Console.SetCursorPosition(55, 0);
                            WriteFullLine("   Score:" + cont * sum + "   ");
                            Console.SetCursorPosition(30, 10);
                            WriteFullLine("   Calculations:" + "    ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.SetCursorPosition(30, 12);
                            for (int b = 6; b < 9; b++)
                            {
                                Console.SetCursorPosition(30, 6 + b + i);

                                Console.Write("(" + ch[i, b] + ch[i + 1, b] + ch[i + 2, b] + ")");

                            }
                            Console.SetCursorPosition(36, 13 + i);
                            Console.WriteLine("= (" + binary + ")10");
                            Console.SetCursorPosition(35, 14 + i);
                            Console.WriteLine("2");
                            Console.SetCursorPosition(30, 16 + i);
                            Console.WriteLine(cont + "x" + sum + "=" + (cont * sum));

                            for (int k = 6; k < 9; k++)
                            {
                                for (int l = i; l < i + 3; l++)
                                {
                                    ch[l, k] = -1;
                                }
                            }

                        }
                    }
                }
                int fin = 0;
                int final = 0;
                for (int i = 0; i < 11 - y; i++)
                {
                    if (i == 3 || i == 7)
                        i++;

                    for (int j = 0; j < 9 - x / 2; j++)
                    {
                        fin = 0;
                        for (int a = 0; a <= y; a++)
                        {
                            for (int b = 0; b <= x / 2; b++)
                            {
                                if ((ch[i + a, j + b] == -1))
                                {
                                    fin++;
                                    if (fin == (x / 2 + 1) * (y + 1))
                                    {
                                        final++;

                                    }



                                }
                            }
                        }
                    }
                }

                if (final == 0)
                {
                    Console.SetCursorPosition(5, 15);
                    Console.WriteLine("GAME OVER!!");
                }
                final = 0;






            }
        }
    }
}
