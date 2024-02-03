namespace Univerisity;
using static Univerisity.Student;
using static Univerisity.Lecturer;

public static class Menu
{
    public static void MainMenu(){
        ChooseMainMenu();
    }

    public static void ChooseMainMenu(){
        System.Console.WriteLine("Pilih No Menu untuk masuk ke menunya :");
        System.Console.WriteLine("1. All student Data");
        System.Console.WriteLine("2. All Tutor Data");
        System.Console.WriteLine("3. About this University");
        System.Console.WriteLine("4. Exit Application");
        System.Console.Write("Inputkan No Menu : ");
        string chooseMenu = Console.ReadLine();
        bool val = Int32.TryParse(chooseMenu, out int chooseMainMenu);
        if(val == true){
            if(chooseMainMenu == 1){
               DisplayAllStudent();
               DisplaySubMenuStudent();
            }else if(chooseMainMenu == 2){
                DisplayAllLecturer();
                DisplaySubmenuLecturer();
            }else if(chooseMainMenu == 3){
                System.Console.WriteLine("University of Cornelius, berdiri sejak 12 Desember 1978 di Amterika Serikat Southern State, di kota Texas.");
            }else if(chooseMainMenu == 4){  
                System.Console.WriteLine("Terimakasih telah berkujung, terimakasih");
            }else{
                System.Console.WriteLine("Hanya Menerima inputan dari 1 - 4, silahkan input ulang");
                ChooseMainMenu();
            }
        }else{
            System.Console.WriteLine("Hanya menerima inputan angka, silahkan inputkan ulang");
            ChooseMainMenu();
        }
    }

    public static void DisplaySubMenuStudent(){
        System.Console.WriteLine("Pilih untuk masuk ke menunya: ");
        System.Console.WriteLine("1. Student Information");
        System.Console.WriteLine("2. Back to Main Menu");
        System.Console.WriteLine("3. Exit Application");
        System.Console.Write("Masukan pilhan menu : ");
        string chooseFirstSubmenuStudent = Console.ReadLine();
        bool valid = int.TryParse(chooseFirstSubmenuStudent, out int chooseSubmenu);
        if(valid == true){
            if(chooseSubmenu == 1){
                SearchDetailStudent();
            }else if(chooseSubmenu == 2){
                ChooseMainMenu();
            }else if(chooseSubmenu == 3){
                System.Console.WriteLine("Terimakasih selamat datang kemabali");
            }else{
                System.Console.WriteLine("Hanya menerima inputan dalam range 1 - 3, silahkan Inputkan kembali");
                DisplaySubMenuStudent();
            }
        }else{
            System.Console.WriteLine("Inputatan hanya boleh dalam bentung angka, silahkan coba kembali");
            DisplaySubMenuStudent();
        }
    }

    public static void DisplaySubmenuLecturer(){
        System.Console.WriteLine("Pilih untuk masuk ke menunya: ");
        System.Console.WriteLine("1. Tutor Information");
        System.Console.WriteLine("2. Back to Main Menu");
        System.Console.WriteLine("3. Exit Application");
        System.Console.Write("Masukan pilhan menu : ");
        string chooseFirstSubmenuStudent = Console.ReadLine();
        bool valid = int.TryParse(chooseFirstSubmenuStudent, out int chooseSubmenu);
        if(valid == true){
            if(chooseSubmenu == 1){
              SearchDetailLecturer();
            }else if(chooseSubmenu == 2){
                ChooseMainMenu();
            }else if(chooseSubmenu == 3){
                System.Console.WriteLine("Terimakasi telah mengunjungi aplikasi ini");
            }else{
                System.Console.WriteLine("Hanya menerima inputan dalam range 1 - 3, silahkan Inputkan kembali");
                DisplaySubMenuStudent();
            }
        }else{
            System.Console.WriteLine("Inputatan hanya boleh dalam bentung angka, silahkan coba kembali");
            DisplaySubMenuStudent();
        }
    }

    public static void SeccondSubmenuStudent(){
         System.Console.WriteLine("Pilih untuk masuk ke menunya: ");
        System.Console.WriteLine("1. Back to All Student Data");
        System.Console.WriteLine("2. Back to Main Menu");
        System.Console.WriteLine("3. Exit Application");
        System.Console.Write("Masukan pilhan menu : ");
        string chooseFirstSubmenuStudent = Console.ReadLine();
        bool valid = int.TryParse(chooseFirstSubmenuStudent, out int chooseSubmenu);
        if(valid == true){
            if(chooseSubmenu == 1){
                DisplayAllStudent();
            }else if(chooseSubmenu == 2){
                ChooseMainMenu();
            }else if(chooseSubmenu == 3){
                System.Console.WriteLine("Terimakasih");
            }else{
                System.Console.WriteLine("Hanya menerima inputan dalam range 1 - 3, silahkan Inputkan kembali");
                DisplaySubMenuStudent();
            }
        }else{
            System.Console.WriteLine("Inputatan hanya boleh dalam bentung angka, silahkan coba kembali");
            DisplaySubMenuStudent();
        }
    }

    public static void SeccondSubmenuLecturer(){
         System.Console.WriteLine("Pilih untuk masuk ke menunya: ");
        System.Console.WriteLine("1. Back to All Tutor Data");
        System.Console.WriteLine("2. Back to Main Menu");
        System.Console.WriteLine("3. Exit Application");
        System.Console.Write("Masukan pilhan menu : ");
        string chooseFirstSubmenuStudent = Console.ReadLine();
        bool valid = int.TryParse(chooseFirstSubmenuStudent, out int chooseSubmenu);
        if(valid == true){
            if(chooseSubmenu == 1){
                DisplayAllLecturer();
            }else if(chooseSubmenu == 2){
                ChooseMainMenu();
            }else if(chooseSubmenu == 3){
                System.Console.WriteLine("Terimakasih");
            }else{
                System.Console.WriteLine("Hanya menerima inputan dalam range 1 - 3, silahkan Inputkan kembali");
                DisplaySubMenuStudent();
            }
        }else{
            System.Console.WriteLine("Inputatan hanya boleh dalam bentung angka, silahkan coba kembali");
            DisplaySubMenuStudent();
        }
    }
}
