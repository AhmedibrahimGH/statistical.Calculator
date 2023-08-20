using System;

public class My_Calculator
{
    public static void Main()
    {
        // ----------------------Varaible initialization Part ---------------//

        // Here we initialize {Input list} , {Mesure of Tendency} ,{Mesure of variability} => with String , because they take Character.
        string IN_Ls, Ms_T, Ms_v;

        // Here we initialize {Total} , {Count}, {Subtotal}, {Variance} ,{Num} , {Mean} , {Max value} , {Min value} , {Range} , {Medain} => with double , because they are number and to Produce fraction point result .        
        double TL = 0, Ct = 0, S_T = 0, V_c = 0, Nm, Mn, M_x, M_n, R_n, MD_n;

        // Here we initialize {Type of Measurment} , {Count} , {Value in mode}, {Z used in for loop } , {lenght of medain}
        int Ty_ms, length, V_M, Z, l_n;


        //                    Begin of the Code                 //


        // Here We use Console.write => to Accept value from user
        Console.Write("Enter List of Integer: ");

        // Here We use Convert.To string Be its type is Character +  Read value from user And Store it in the Varaible + After user input a value it call and Read the line and appear a message .
        IN_Ls = Convert.ToString(Console.ReadLine());

        //  Here After User input the Values in the List this Messages will Appear
        Console.WriteLine("General types of measurement:");
        Console.WriteLine("1- Measure of central tendency");
        Console.WriteLine("2- Measure of variability");

        Console.WriteLine(" \n Enter the general type of measurement:");

        // Here We use Convert.ToInt32 Be it covert from strint to int. +  Read value from user And Store it in the Varaible + After user input a value it call and Read the line and appear a message .
        Ty_ms = Convert.ToInt32(Console.ReadLine());

        // Here we use switch case to put cases for user if He Enter Specfic input      + Used Like If/Esle Condition.
        switch (Ty_ms)
        {
            // Here Case if user Enter Number {1} , If it's true Will Excute what inside the Case
            case 1:
                // if The Case is True It will Print This Message //
                Console.WriteLine("List of Central Tendency Measurements:");
                Console.WriteLine("1.1 Mean");
                Console.WriteLine("1.2 Mode");
                Console.WriteLine("1.3 Median");

                Console.WriteLine("\nEnter the specific type of measurement:");

                // Here We use Convert.To string Be its type is Character +  Read value from user And Store it in the Varaible + After user input a value it call and Read the line and appear a message .
                Ms_T = Convert.ToString(Console.ReadLine());

                // Here We use if inside Switch Case To put Condition , if User Acheive Case {1} ,  It will Appear Many options And We Put Condition to Each Option User will input it .
                if (Ms_T == "1.1")
                {
                    // If Condition is True , The foreach Loop will iterate inside {input List} + .Spilt is used to Large Number of string into smaller one And it used for the spaces .
                    foreach (string X in IN_Ls.Split())
                    {
                        //  Here{Num} Convert String Value Of varabile x  To Double Value.
                        Nm = Convert.ToDouble(X);

                        // here we add value of {total} to {Num}
                        TL = TL + Nm;
                        // Here {Count} is increased by 1 , And Value Stored back to it.
                        Ct = Ct + 1;
                    }

                    // here {mean} Equal value of {Total} Divide value of {Count}
                    Mn = TL / Ct;


                    Console.WriteLine("The Mean of a set of values equals (sum(values)/count(values)");
                    // here it Will appear Message For user + It Contain The Value of Mean After Calculation Based on His Input.
                    Console.WriteLine("The Mean of the entered data set is ({0})", Mn);
                }
                // here Condition Work If User Input value{1.2}, if The Codition is True It Will  Excuete What Inside Elseif.
                else if (Ms_T == "1.2")
                {
                    // here We initialize {Mode} ,{Count-Mode} , {ADD-up}
                    int M_D = 0, CT_M = 0, AD_Up = 0;


                    // If Condition is True , The foreach Loop will iterate inside {input List} + .Spilt is used to divide Large Number of string into smaller one And it used for the spaces .
                    foreach (string U in IN_Ls.Split())
                    {
                        // If Condition in loop is Sastified it Will Excuete What inside The Loop + Here {Value mode} Convert String Value Of varabile U  To Integer Value.
                        V_M = Convert.ToInt32(U);
                        AD_Up = 0;

                        // Here This Nested Loop Which is Loop Inside loop this the loop Inside The Main Loop which we Preform Like Each other but Different Varaible Names.
                        foreach (string Y in IN_Ls.Split())
                        {
                            //  Here{Count Mode} Convert String Value Of varabile Y  To Int. Value. 
                            CT_M = Convert.ToInt32(Y);

                            // Here Condition say if {Count Mode} Equal {Value in mode} Then Excuete What Inside.
                            if (CT_M == V_M)
                            {
                                // If Condition is True The {Add-up} will Increase by 1 Then It Will Stored in it .
                                AD_Up = AD_Up + 1;
                            }
                        }

                        // Here Condition Say That if {Add-up} Greater than {Count Mode } Excuete What Inside .
                        if (AD_Up > CT_M)
                        {
                            // Here {Count Mode } is Assigned by {Add-up}  
                            CT_M = AD_Up;
                            // Here { Mode } is Assigned by {Value in mode} 
                            M_D = V_M;
                        }
                    }

                    Console.WriteLine("The Mode of a set of values is the value repeated most of time in central set");

                    // Here it Will appear Message For user + It Contain The Value of Mode After Calculation Based on His Input.
                    Console.WriteLine("The Mode of the entered data set is ({0})", M_D);
                }

                // Here Condition Work If User Input value{1.3}, if The Codition is True It Will  Excuete What Inside Elseif.
                else if (Ms_T == "1.3")
                {
                    // Here it  Divide String into Smaller one And Store it Again in {Value of Length}
                    string[] VL_L = IN_Ls.Split();

                    // here It Calculate the Length of Array Then Assign it to {Lenght of Medain}
                    l_n = VL_L.Length;

                    //Here this Calculate Empty List With Certain Size , And Store it in {Mode Value}
                    double[] M_V = new double[l_n];

                    // Here We use For Loop To iterate inside loop if Condition is True.
                    for (Z = 0; Z < l_n; Z++)
                    {
                        // Here This Convert string that is in the Array And Convert it into double .
                        M_V[Z] = Convert.ToDouble(VL_L[Z]);
                    }

                    // This Is Used To arrange ,Value Inside The Array In Asending Order. 
                    Array.Sort(M_V);

                    // Here Condition Check If {Lenght of Medain} is Even Number, if it's true then It Will Excuete What Inside Condition.
                    if (l_n % 2 == 0)
                    {
                        // Here It will Preform Calculation To Calculate Medain of Even Numbers.
                        MD_n = (M_V[l_n / 2 - 1] + M_V[l_n / 2]) / 2.0;
                        Console.WriteLine("The Median of a set of even number of values is the average of the two middle values .");

                    }
                    // Here if Condition is Not Sastified Then It Will Goto Else And Excuete What Inside it.
                    else
                    {
                        // Here It will Preform Calculation To Calculate Medain of odd Numbers
                        MD_n = M_V[l_n / 2];
                        Console.WriteLine("The Median of a set of odd number of values is the middle value.");
                    }

                    // Here it Will appear Message For user + It Contain The Value of Medain After Calculation Based on His Input.
                    Console.WriteLine("The Median of the entered data set is ({0})", MD_n);
                }

                break;


            // Here Case if user Enter Number {2} , If it's true Will Excute what inside the Case    
            case 2:
                // if The Case is True It will Print This Message //
                Console.WriteLine("List of Central Tendency Measurements: ");
                Console.WriteLine("2.1 Range");
                Console.WriteLine("2.2 Variance");
                Console.WriteLine("Enter the required calculation: ");

                // Here We use Convert.To string Be its type is Character +  Read value from user And Store it in the Varaible + After user input a value it call and Read the line and appear a message .
                Ms_v = Convert.ToString(Console.ReadLine());

                // Here we use switch case to put cases for user if He Enter Specfic input + Used Like If/Esle Condition.
                switch (Ms_v)
                {

                    // Here Case When User Input {2.1} The Condition Will be Excueted.
                    case "2.1":
                        // Here {Max} is Assigned By The Smallest value That Can Be Stored .
                        M_x = int.MinValue;

                        // Here {Min} is Assigned By The Largest value That Can Be Stored.
                        M_n = int.MaxValue;

                        // The foreach Loop will iterate inside {input List} + .Spilt is used to divide Large Number of string into smaller one And it used for the spaces 
                        foreach (string Q in IN_Ls.Split())
                        {

                            //  Here{Range} Convert String Value Of varabile Q To Double Value. 
                            R_n = Convert.ToDouble(Q);

                            //  Here If Condition is used To allow us To Find Minimum Value .
                            if (R_n < M_n) M_n = R_n;

                            //  Here else if Condition is used To allow us To Find Maximum Value .
                            else if (R_n > M_x) M_x = R_n;
                        }

                        Console.WriteLine("The Range of a set of values is the difference between the maximum and minimum values");

                        // Here it Will appear Message For user + It Contain The Value of Range{Max-Min} After Calculation Based on His Input.
                        Console.WriteLine("The Range of the entered data set is ({0})", M_x - M_n);
                        break;

                    // Here Case When User Input {2.2} The Condition Will be Excueted.
                    case "2.2":

                        // The foreach Loop will iterate inside {input List} + .Spilt is used to divide Large Number of string into smaller one And it used for the spaces 
                        foreach (string s in IN_Ls.Split())
                        {

                            double V = Convert.ToDouble(s);
                            // here {Sub total} Is Added by{V} And Store value inside it . 
                            S_T = S_T + V;

                            // Here {Count} is increased by 1 , And Value Stored back to it.
                            Ct = Ct + 1;
                        }

                        // Here {Sub total} is Divided By {Count} And Assigned to {Mean}.
                        Mn = S_T / Ct;
                        S_T = 0;

                        // The foreach Loop will iterate inside {input List} + .Spilt is used to divide Large Number of string into smaller one And it used for the spaces
                        foreach (string s in IN_Ls.Split())
                        {
                            double n = Convert.ToDouble(s);
                            // here {Sub total} is Added to Math Function To Preform Calculation and Stored Back To it.
                            S_T = S_T + Math.Pow(n - Mn, 2);
                        }
                        // Here {Subtotal} is Divided By {Count} And Assigned To {Variance}
                        V_c = S_T / Ct;

                        Console.WriteLine("The Variance of a set of values is the average of the squared differences from the mean");

                        // Here it Will appear Message For user + It Contain The Value of {Variance} After Calculation Based on His Input.
                        Console.WriteLine("The Variance of the entered data set is ({0})", V_c);

                        break;
                }
                // Here break is used To End The Case After it Excuted //
                break;

            // Default=> Is used like Else Condition, If The Cases Are Not Satisfied  It Will Goto the Default And Excuete Statment inside it//
            default:
                Console.WriteLine("Invalid Input!");
                break;
        }
    }
}