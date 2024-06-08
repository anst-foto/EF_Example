using EF_Example;

var db = new DataBaseContext();

var admin = new Role()
{
    Name = "Admin"
};
var guest = new Role()
{
    Name = "Guest"
};
db.Roles.Add(admin);
db.Roles.Add(guest);

db.Users.Add(new User()
{
    Name = "John1",
    DateOfBirth = new DateTime(1990, 1, 1),
    Role = admin
});
db.Users.Add(new User()
{
    Name = "John2",
    DateOfBirth = new DateTime(1990, 1, 1),
    Role = admin
});
db.Users.Add(new User()
{
    Name = "John3",
    DateOfBirth = new DateTime(1991, 1, 1),
    Role = guest
});
db.SaveChanges();

foreach (var user in db.Users)
{
    Console.WriteLine($"{user.Id}: {user.Name} - {user.DateOfBirth:d} ({user.Role.Name})");
}

foreach (var role in db.Roles)
{
    Console.WriteLine($"{role.Id}:  {role.Name}");
    foreach (var user in role.Users)
    {
        Console.WriteLine($"{user.Id}: {user.Name} - {user.DateOfBirth:d}");
    }
}