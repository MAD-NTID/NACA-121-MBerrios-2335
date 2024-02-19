public class Alien
{
    public const string CAPTAIN_ROLE = "Captain", CHIEF_ROLE = "Chief Officer";

    private string name, role;

    public string Name
    {
        get 
        {
            return name;
        }

        set
        {
            // ternary operator approach
            name = string.IsNullOrEmpty(value) ? "Undefined Name" : value;

            // if(string.IsNullOrEmpty(value))
            //     name = "Undefined Name";
            // else
            //     name = value;
        }
    }

    public string Role
    {
        get
        {
            return role;
        }
        
        set
        {
            //  ternary operator approach
            role = IsValidRole(value) ? value : "Unknown Role";
            
            // if(IsValidRole(value))
            //     role = value;
            // else
            //     role = "Unknown Role";
        }
    }

    public Alien(string name, string role)
    {
        Name = name;
        Role = role;
    }

    private bool IsValidRole(string role)
    {
        string[] validRoles = new string[]
        {
            CAPTAIN_ROLE,
            CHIEF_ROLE,
            "Navigator",
            "Pilot",
            "Engineer",
            "Doctor"
        };

        if(string.IsNullOrEmpty(role))
            return false;

        for(int i = 0; i < validRoles.Length; i++)
            if(role.ToLower() == validRoles[i].ToLower())
                return true;

        return false;
    }

    public bool IsCaptain()
    {
        return role.ToLower() == CAPTAIN_ROLE.ToLower();
    }

    public bool IsChief()
    {
        return role.ToLower() == CHIEF_ROLE.ToLower();
    }

    public override string ToString()
    {
        return $"Name: {name} Role: {role}";
    }
}