// Three basic arrays
int[] arrOfInts;
arrOfInts = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

string[] arrOfNames;
arrOfNames = new string[] {"Tim", "Martin", "Nikki", "Sara"};

bool[] arrOfBool = new bool[10];

for (int i = 0; i <arrOfBool.Length; i++){
    if(i % 2 == 0){
        arrOfBool[i] = true;
    }
    else{
        arrOfBool[i]=false;
        }
}

// List of flavors
List<string> iceCreamFlavors = new List<string>();
iceCreamFlavors.Add("Strawberry");
iceCreamFlavors.Add("Chocolate");
iceCreamFlavors.Add("Vanilla");
iceCreamFlavors.Add("Cookie Dough");
iceCreamFlavors.Add("Birthday Cake");
Console.WriteLine(iceCreamFlavors.Count);
Console.WriteLine(iceCreamFlavors[2]);
iceCreamFlavors.RemoveAt(2);
Console.WriteLine(iceCreamFlavors.Count);


// User dictionary 
Random randFlavor = new Random();
Dictionary<string, string> users = new Dictionary<string, string>();
foreach(string name in arrOfNames){
    int randomIndex = randFlavor.Next(iceCreamFlavors.Count);
    string selectedFlavor = iceCreamFlavors[randomIndex];
    users.Add(name, selectedFlavor);
}

foreach(KeyValuePair<string,string> user in users)
{
    Console.WriteLine($"Name: {user.Key} - Favorite flavor: {user.Value}");
}





