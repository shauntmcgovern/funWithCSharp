class clown {
    public string name;
    public int height;
    public string occupation;
    
    public void stateYourBusiness() {
        Console.WriteLine("My name is " + name + "and I'm " + height + " inches tall " + " and I am a " + occupation);
    }
}

static void Main(string[] args) {
    clown oneClown = new Clown();
    oneClown.name = "Boffo";
    oneClown.height = 14;
    oneClown.occupation = "Plumber";
    oneClown.stateYourBusiness(); 
    
    clown anotherClown = new Clown();
    anotherClown.name = "Biff";
    anotherClown.height = 16;
    anotherClown.occupation = "Fighter";
    anotherClown.stateYourBusiness();
    
    clown clown3 = new Clown();
    clown3.name = anotherClown.Name;
    clown3.height = oneClown.Height - 3;
    clown3.occupation = "Plumber's Assistant";
    clown3.stateYourBusiness();
    
    anotherClown.height *= 2;
    anotherClown.stateYourBusiness();
    
    clown lastClown = new Clown();
    lastClown.name = "Doink";
    lastClown.height = 21;
    lastClown.occupation = "Wrestler";
    lastClown.stateYourBusiness();
}
