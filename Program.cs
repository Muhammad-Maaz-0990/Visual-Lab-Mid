using System;



namespace Lab_Mid
    {
        class User
            {
                int userID;
                string name="";
                string phoneNumber = "";



        public void register(int ID, string i_name,string number)
        {
            userID = ID;
            name = i_name;
            phoneNumber = number;

            Console.WriteLine("User Registered Successfully");

        }

        public bool login(int ID, string i_name, string number)
        {
            if(userID == ID &&   name==i_name   &&  phoneNumber==number)
            {
                Console.WriteLine("Login Successfully");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid Inputs\nLogin Denied");
                return false;
            }
        }

        public void displayProfile()
        {
            Console.WriteLine("UserID: "+ userID + "\nUserName: " + name + "\nPhone Number : " + phoneNumber);
            Console.ReadKey();
        }

            }
   

    class Rider:User
    {
        List<Trip> rideHistory = new List<Trip>();
        
        public void viewRideHistory()
        {
            //Console.WriteLine("\n\nTripID : " + rideHistory + "\nRider Name : " + "\nFrom : " + startLocation + "\nTo : " + destination + "\nFare : " + fare );
        }

        public void requestride()
        {
            Console.WriteLine("\nEnter Your Current Location: ");
            string locat = (Console.ReadLine()).ToString();
            Console.WriteLine("\nEnter Your Destination : ");
            string dest = (Console.ReadLine()).ToString();

        }

    }

    class Driver : User
    {
        int driverID;
        string vehicleDetails;
        string isAvailable;
        List<Trip> TripHistory = new List<Trip>();


        public Driver()
        {
            driverID = 0;
            vehicleDetails = "";
            isAvailable = "Yes";
        }

        public void viewRideHistory()
        {
            //Console.WriteLine("\n\nTripID : " + rideHistory + "\nRider Name : " + "\nFrom : " + startLocation + "\nTo : " + destination + "\nFare : " + fare );
        }


        public void toggleAvailability()
        {
            if(isAvailable == "Yes")
            {
                isAvailable = "No";
            }
            else
            {
                isAvailable = "Yes";
            }
        }





        public void requestride()
        {
            Console.WriteLine("\nEnter Your Current Location: ");
            string locat = (Console.ReadLine()).ToString();
            Console.WriteLine("\nEnter Your Destination : ");
            string dest = (Console.ReadLine()).ToString();

        }



    }


    class Trip
    {
        int tripID;
        string rider_Name = "";
        string drivenName = "";
        string startLocation = "";
        string destination = "";

        int fare;
        string status="";

        void set_TripID(int ID)
        {
            tripID = ID;
        }

        void set_ridername(string name)
        {
            rider_Name = name;
        }
        void set_drivername(string name)
        {
            drivenName = name;
        }
        void set_startlocation(string loc)
        {
            startLocation = loc;
        }
        void set_destination(string des)
        {
            destination = des;
        }

        void set_fare(int f)
        {
            fare = f;
        }

        void set_status(string st)
        {
            status = st;
        }


        int get_TripID(int ID)
        {
            return tripID;
        }

        string get_ridername()
        {
            return rider_Name;
        }
        string get_drivername()
        {
            return drivenName;
        }
        string get_startlocation()
        {
            return startLocation;
        }
        string get_destination()
        {
            return destination;
        }

        int get_fare()
        {
            return fare;
        }

        string get_status()
        {
            return status;
        }

        public void startTrip()
        {
            status = "Start";
        }

        public void endTrip()
        {
            status = "end";
        }


        public void displayTripDetails()
        {
            Console.WriteLine("\n\nTripID : " + tripID + "\nRider Name : "+rider_Name+"\nDriver Name : "+drivenName +"\nFrom : " + startLocation + "\nTo : "+ destination + "\nFare : "+fare+ "Status : "+status);
        }


    }

    class RideSharingSystem
    {
        List<Rider> registeredRiders = new List<Rider>();
        List<Driver> registeredDrivers = new List<Driver>();
        List<Trip> AvailableTrips = new List<Trip>();

        public void registerUser()
        {
            Console.WriteLine("Enter");
        }

        static public string check_phone_number(string number)
        {
            while(true)
            {
                bool check = true;
                if(number.Length == 11)
                {
                    foreach (var a in number)
                    {
                        if (!(a >= '0' && a <= '9'))
                        {
                            check = true;
                            break;
                        }
                        else
                        {
                            check = false;
                        }

                    }
                }
                if(check)
                {
                    Console.WriteLine("Enter Correct Phone Number : ");
                    number = Console.ReadLine();
                }
                else
                {
                    return number;
                }
            }
        }

        static public void Main(string[] args)
        {
            int choice;
            string rider_name="", driver_name="";
            string d_phone, r_phone;

            int Tripid= 0;
            string location="";
            string dest = "";
            int fare = 0;
            string status = "Done";

            while(true)
            {
                Console.Clear();
                Console.WriteLine("\t\t\tWelcome to the Ride-Sharing System");
                Console.WriteLine("\n1. Register as Rider\n2. Register as driver");
                Console.WriteLine("3. Request a Ride");
                Console.WriteLine("4. Accept a Ride");
                Console.WriteLine("5. Complete a Trip");
                Console.WriteLine("6. View Ride History");
                Console.WriteLine("7. View Trip History");
                Console.WriteLine("8. Display All Trips");
                Console.WriteLine("9. Exit");

                Console.Write("\n\nChoose [1-9] : ");
                choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 1)
                {
                    Console.Clear ();
                    Console.WriteLine("\t\t\tWelcome to the Ride-Sharing System");
                    Console.Write("\n\nEnter Your Name : ");
                    rider_name = Console.ReadLine();
                    Console.Write("Enter Your Phone Number : ");
                    r_phone = Console.ReadLine();
                    r_phone = check_phone_number(r_phone);

                    Console.WriteLine(rider_name + " Rider Registered Successfully");
                    Console.ReadKey();

                }
                else if(choice == 2)
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\tWelcome to the Ride-Sharing System");
                    Console.Write("\n\nEnter Your Name : ");
                    driver_name = Console.ReadLine();
                    Console.Write("Enter Your Phone Number : ");
                    d_phone = Console.ReadLine();
                    d_phone = check_phone_number(d_phone);
                    Console.WriteLine(driver_name + " Driver Registered Successfully");
                    Console.ReadKey();
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\tWelcome to the Ride-Sharing System");
                    Console.Write("\n\nEnter Your Current Location : ");
                    location = Console.ReadLine();
                    Console.Write("Enter Your Destination : ");
                    dest = Console.ReadLine();
                    Tripid = Tripid + 1;
                    Console.WriteLine("\nRide Registered Successfully");
                    Console.ReadKey();
                }

                else if (choice == 4)
                {
                    if (driver_name != "")
                    {
                        Console.Clear();
                        fare = Tripid * 36;
                        Console.WriteLine("\nDriver " + driver_name + " accepted the ride request from "+rider_name);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("\nFirst Register any Driver");
                        Console.ReadKey();
                    }

                }

                else if (choice == 5)
                {
                    if (Tripid != 0)
                    {
                        Console.Clear();
                        Console.WriteLine("\nTrip From " + location  + " to " + dest + "has been Completed");
                        Console.WriteLine("Fare : " + fare);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("\nNo Trip Found");
                        Console.ReadKey();
                    }

                }

                else if (choice == 6)
                {
                    if (Tripid != 0)
                    {
                        Console.Clear();
                        Console.WriteLine("\t\t\t\tYour Ride History : ");
                        Console.WriteLine("\n\nTrip ID : " + Tripid);
                        Console.WriteLine("\n\nFrom : " + location);
                        Console.WriteLine("\n\nTo : " + dest);
                        Console.WriteLine("Fare : " + fare);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("\nNo Trip Found");
                        Console.ReadKey();
                    }

                }

                else if (choice == 7)
                {
                    if (Tripid != 0)
                    {
                        Console.Clear();
                        Console.WriteLine("\t\t\t\tTrip History : ");
                        Console.WriteLine("\n\nTrip ID : " + Tripid);
                        Console.WriteLine("\n\nDriver : " + driver_name);
                        Console.WriteLine("\n\nFrom : " + location);
                        Console.WriteLine("\n\nTo : " + dest);
                        Console.WriteLine("Fare : " + fare);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("\nNo Trip Found");
                        Console.ReadKey();
                    }

                }

                else if (choice == 8)
                {
                    if (Tripid != 0)
                    {
                        Console.Clear();
                        Console.WriteLine("\t\t\t\tTrip History : ");
                        Console.WriteLine("\n\nTrip ID : " + Tripid);
                        Console.WriteLine("\n\nRider : " + rider_name);
                        Console.WriteLine("\n\nDriver : " + driver_name);
                        Console.WriteLine("\n\nFrom : " + location);
                        Console.WriteLine("\n\nTo : " + dest);
                        Console.WriteLine("Fare : " + fare);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("\nNo Trip Found");
                        Console.ReadKey();
                    }

                }

                else if (choice == 9)
                {
                    Console.Clear();
                    Console.WriteLine("Good Bye");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadLine();
                }
            }
            



        }

    }

}