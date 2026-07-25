using System;

namespace StudentAdmissionManagement
{
    class Student
    {
        // Private Data Members
        private string studentName;
        private string fatherName;
        private string motherName;
        private string gender;
        private string dob;
        private string aadhaar;
        private string mobile;
        private string email;
        private string address;
        private string city;
        private string state;
        private string pinCode;

        private double tenthPer;
        private double twelfthPer;

        private string courseName;
        private int courseFee;

        private bool hostelRequired;
        private string sharingType;
        private int hostelFee;

        private bool busRequired;
        private int busFee;

        private int grNumber;
        private int rollNumber;

        private double totalFee;

        static Random random = new Random();

        // Constructor
        public Student(string sName, string fName, string mName,
                       string gen, string birth, string adhar,
                       string mob, string mail, string add,
                       string cty, string st, string pin,
                       double per10, double per12)
        {
            studentName = sName;
            fatherName = fName;
            motherName = mName;
            gender = gen;
            dob = birth;
            aadhaar = adhar;
            mobile = mob;
            email = mail;
            address = add;
            city = cty;
            state = st;
            pinCode = pin;
            tenthPer = per10;
            twelfthPer = per12;

            // Initialize fields
            courseName = "";
            sharingType = "";

            // Auto Generate Numbers
            grNumber = random.Next(100000, 999999);
            rollNumber = random.Next(10000, 99999);
        }

        // Eligibility Check
        public bool CheckEligibility()
        {
            return (tenthPer >= 60 && twelfthPer >= 60);
        }

        // Course Selection
        public void SelectCourse()
        {
            Console.WriteLine("\n=========== COURSE LIST ===========");
            Console.WriteLine("1. BCA              Fee : ₹45,000");
            Console.WriteLine("2. B.Sc IT          Fee : ₹42,000");
            Console.WriteLine("3. MCA              Fee : ₹60,000");
            Console.WriteLine("4. MBA              Fee : ₹70,000");
            Console.WriteLine("5. B.Tech CSE       Fee : ₹95,000");

            Console.Write("\nSelect Course (1-5): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    courseName = "BCA";
                    courseFee = 45000;
                    break;

                case 2:
                    courseName = "B.Sc IT";
                    courseFee = 42000;
                    break;

                case 3:
                    courseName = "MCA";
                    courseFee = 60000;
                    break;

                case 4:
                    courseName = "MBA";
                    courseFee = 70000;
                    break;

                case 5:
                    courseName = "B.Tech CSE";
                    courseFee = 95000;
                    break;

                default:
                    Console.WriteLine("Invalid Course.");
                    Environment.Exit(0);
                    break;
            }
        }

        // Hostel Details
        public void HostelDetails()
        {
            Console.Write("\nDo you need Hostel? (Y/N): ");
            char ch = Convert.ToChar(Console.ReadLine() ?? "");

            if (ch == 'Y' || ch == 'y')
            {
                hostelRequired = true;

                Console.WriteLine("\nHostel Sharing");
                Console.WriteLine("1. Single Sharing  - ₹60,000");
                Console.WriteLine("2. Double Sharing  - ₹45,000");
                Console.WriteLine("3. Triple Sharing  - ₹35,000");

                Console.Write("Select Sharing: ");
                int s = Convert.ToInt32(Console.ReadLine());

                switch (s)
                {
                    case 1:
                        sharingType = "Single";
                        hostelFee = 60000;
                        break;

                    case 2:
                        sharingType = "Double";
                        hostelFee = 45000;
                        break;

                    case 3:
                        sharingType = "Triple";
                        hostelFee = 35000;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                hostelRequired = false;
                sharingType = "No Hostel";
                hostelFee = 0;
            }
        }

        // Bus Details
        public void BusDetails()
        {
            Console.Write("\nDo you need Bus Facility? (Y/N): ");
            char ch = Convert.ToChar(Console.ReadLine() ?? "");

            if (ch == 'Y' || ch == 'y')
            {
                busRequired = true;
                busFee = 12000;
            }
            else
            {
                busRequired = false;
                busFee = 0;
            }
        }

        // Scholarship
        public void Scholarship()
        {
            if (twelfthPer >= 90)
            {
                Console.WriteLine("\nCongratulations! 20% Scholarship Applied.");
                courseFee = courseFee - (courseFee * 20 / 100);
            }
        }
                // Calculate Total Fee
        public void CalculateTotalFee()
        {
            totalFee = courseFee + hostelFee + busFee;
        }

        // Display Final Receipt
        public void DisplayReceipt()
        {
            Console.WriteLine("\n====================================================");
            Console.WriteLine("          STUDENT ADMISSION RECEIPT");
            Console.WriteLine("====================================================");
            Console.WriteLine("Admission Status : SUCCESS");
            Console.WriteLine("Admission Date   : " + DateTime.Now.ToShortDateString());

            Console.WriteLine("\nGR Number        : " + grNumber);
            Console.WriteLine("Roll Number      : " + rollNumber);

            Console.WriteLine("\nStudent Name     : " + studentName);
            Console.WriteLine("Father Name      : " + fatherName);
            Console.WriteLine("Mother Name      : " + motherName);
            Console.WriteLine("Gender           : " + gender);
            Console.WriteLine("Date of Birth    : " + dob);

            Console.WriteLine("Aadhaar Number   : " + aadhaar);
            Console.WriteLine("Mobile Number    : " + mobile);
            Console.WriteLine("Email            : " + email);

            Console.WriteLine("\nAddress          : " + address);
            Console.WriteLine("City             : " + city);
            Console.WriteLine("State            : " + state);
            Console.WriteLine("PIN Code         : " + pinCode);

            Console.WriteLine("\n10th Percentage  : " + tenthPer + "%");
            Console.WriteLine("12th Percentage  : " + twelfthPer + "%");

            Console.WriteLine("\nCourse           : " + courseName);
            Console.WriteLine("Course Fee       : ₹" + courseFee);

            Console.WriteLine("\nHostel           : " + (hostelRequired ? "YES" : "NO"));
            Console.WriteLine("Sharing          : " + sharingType);
            Console.WriteLine("Hostel Fee       : ₹" + hostelFee);

            Console.WriteLine("\nBus Facility     : " + (busRequired ? "YES" : "NO"));
            Console.WriteLine("Bus Fee          : ₹" + busFee);

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("TOTAL FEES       : ₹" + totalFee);
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Thank You For Taking Admission.");
            Console.WriteLine("====================================================");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("   STUDENT ADMISSION MANAGEMENT SYSTEM");
            Console.WriteLine("=============================================\n");

            Console.Write("Student Name : ");
            string sName = Console.ReadLine() ?? "";

            Console.Write("Father Name : ");
            string fName = Console.ReadLine() ?? "";

            Console.Write("Mother Name : ");
            string mName = Console.ReadLine() ?? "";

            Console.Write("Gender : ");
            string gender = Console.ReadLine() ?? "";

            Console.Write("Date of Birth (DD/MM/YYYY) : ");
            string dob = Console.ReadLine() ?? "";

            // Aadhaar Validation
            string aadhaar;
            do
            {
                Console.Write("Enter Aadhaar Number (12 Digits): ");
                aadhaar = Console.ReadLine() ?? "";

                if (aadhaar.Length != 12)
                    Console.WriteLine("Invalid Aadhaar Number! Please Enter Exactly 12 Digits.");
            }
            while (aadhaar.Length != 12);

            // Mobile Validation
            string mobile;
            do
            {
                Console.Write("Enter Mobile Number (10 Digits): ");
                mobile = Console.ReadLine() ?? "";

                if (mobile.Length != 10)
                    Console.WriteLine("Invalid Mobile Number! Please Enter Exactly 10 Digits.");
            }
            while (mobile.Length != 10);

            Console.Write("Email : ");
            string email = Console.ReadLine() ?? "";

            Console.Write("Address : ");
            string address = Console.ReadLine() ?? "";

            Console.Write("City : ");
            string city = Console.ReadLine() ?? "";

            Console.Write("State : ");
            string state = Console.ReadLine() ?? "";

            Console.Write("PIN Code : ");
            string pin = Console.ReadLine() ?? "";

            Console.Write("10th Percentage : ");
            double p10 = Convert.ToDouble(Console.ReadLine());

            Console.Write("12th Percentage : ");
            double p12 = Convert.ToDouble(Console.ReadLine());

            Student stu = new Student(
                sName, fName, mName,
                gender, dob, aadhaar,
                mobile, email, address,
                city, state, pin,
                p10, p12);

            // Eligibility Check
            if (!stu.CheckEligibility())
            {
                Console.WriteLine("\nSorry! Admission Rejected.");
                Console.WriteLine("Minimum 60% marks required in both 10th and 12th.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\nCongratulations! You are Eligible for Admission.");

            stu.SelectCourse();
            stu.HostelDetails();
            stu.BusDetails();
            stu.Scholarship();
            stu.CalculateTotalFee();
            stu.DisplayReceipt();

            Console.WriteLine("\nPress Any Key To Exit...");
            Console.ReadKey();
        }
    }
}