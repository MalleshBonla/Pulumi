using Pulumi;
using Random = Pulumi.Random;

class MyStack : Stack
{
    public MyStack()
    {
        var random_pet = new Random.RandomPet("random-pet", new Random.RandomPetArgs
        {
            Prefix = "doggo",
        });
    }

}
