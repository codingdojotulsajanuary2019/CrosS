users = [
    {
      fname: "Kermit",
      lname: "the Frog",
      languages: ["Python", "JavaScript", "C#", "HTML", "CSS", "SQL"],
      interests: {
        music: ["guitar", "flute"],
        dance: ["tap", "salsa"],
        television: ["Black Mirror", "Stranger Things"]
      }
    },
    {
      fname: "Winnie",
      lname: "the Pooh",
      languages: ["Python", "Swift", "Java"],
      interests: {
        food: ["honey", "honeycomb"],
        flowers: ["honeysuckle"],
        mysteries: ["Heffalumps"]
      }
    },
    {
      fname: "Arthur",
      lname: "Dent",
      languages: ["JavaScript", "HTML", "Go"],
      interests: {
        space: ["stars", "planets", "improbability"],
        home: ["tea", "yellow bulldozers"]
      }
    }
  ]
function userLanguages(value)
{
    for(var key in value)
    {
        var string = "";
        string += `${value[key].fname} `;
        string += `${value[key].lname} `;
        string += "knows ";
        for(var dict in value[key].languages)
        {
            if(dict != value[key].languages.length - 1)
            {
                string += `${value[key].languages[dict]}, `;
                // string += `and ${value[key].languages[dict]}`
            }
            else
            {
                // string += `${value[key].languages[dict]}, `;
                string += `and ${value[key].languages[dict]}`
            }
        }
        console.log(string);
    }
}
userLanguages(users);
    