namespace SKILLS;


public class Comments
{

// create a method that generates a comment for a given skill
// the comment should be a random string of 50 characters
// the comment should be saved to the skill's comments property
// the method should return the comment
public string GenerateComment(Skill skill)
{
    string comment = "";
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    Random random = new Random();
    for (int i = 0; i < 50; i++)
    {
        comment += chars[random.Next(chars.Length)];
    }
    skill.Comments = comment;
    return comment;
}

// create a method that generates a random number of comments for a given skill
// the number of comments should be between 0 and 10
// each comment should be a random string of 50 characters
// the comments should be saved to the skill's comments property
// the method should return the number of comments generated
public int GenerateComments(Skill skill)
{
    int numComments = new Random().Next(0, 11);
    for (int i = 0; i < numComments; i++)
    {
        GenerateComment(skill);
    }
    return numComments;
}

// create a method that prints all the comments for a given skill
public void PrintComments(Skill skill)
{
    Console.WriteLine($"Comments for skill {skill.Name}:");
    Console.WriteLine(skill.Comments);
}

// create a method that clears all the comments for a given skill
public void ClearComments(Skill skill)
{
    skill.Comments = "";
}

}