DisplayMenu();
string userChoice = GetUserChoice();
Random random = new Random();
int randomRows = random.Next(8,13); 

while (userChoice !="4"){
    RouteEm(userChoice, randomRows);
    DisplayMenu();
    userChoice= GetUserChoice();
}

static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("Welcome to Crimson Crust");
    Console.WriteLine ("1. Plain Pizza\n2. Cheese Pizza\n3. Pepperoni Pizza\n4. Exit");
}

static string GetUserChoice(){
    return Console.ReadLine();
}

static void RouteEm(string userInput, int randomRows){
    switch (userInput){
        case "1":
            PlainPizza(randomRows);
            break;
        case "2":
            CheesePizza(randomRows);
            break;
        case "3":
            PepperoniPizza(randomRows);
            break;
        case "4":
            Exit();
            break;
        default:
        BadInput();
        break;
}
}
static void BadInput(){
    Console.WriteLine("Invalid selection, try again!");
    Pause();
}

static void Pause(){
    Console.WriteLine("Press any key to continue");
    Console.ReadKey();
}

static void Exit(){
    Console.WriteLine("You have exited the program!");
    Pause();
}

static void PlainPizza(int randomRows){
for (int i = randomRows ; i >= 0 ; i--){
    for (int j =0 ; j < i+1; j++){
        System.Console.Write("*\t");
    }
    Console.WriteLine();
}
Pause();
}

static void CheesePizza(int randomRows){
    for (int i = randomRows; i >= 0; i--){
        for (int j = 0; j < i + 1; j++){
            // Print '*' on the border (first or last row, or first or last column)
            if (i == randomRows || i == 0 || j == 0 || j == i){
                Console.Write("*\t");
                }
            else{
                Console.Write("#\t");
                }
        }
        Console.WriteLine();
    }
    Pause();
}


static void PepperoniPizza(int randomRows){
    Random rand = new Random();
    int randompepCol = rand.Next(1,randomRows+1);
    int randompepRow = rand.Next(1,randomRows);
       for (int i = randomRows; i >= 0; i--){
        for (int j = 0; j < i + 1; j++){
            // Print '*' on the border (first or last row, or first or last column)
            if (i == randomRows || i == 0 || j == 0 || j == i){
                Console.Write("*\t");
                }
            else if (i == randompepRow || j == randompepCol){
                randompepCol = randompepCol /3; 
                Console.Write("[]\t");
            }
            else{
                Console.Write("#\t");
                }
        }
        Console.WriteLine();
    }
    Pause();
}





