let students = [
    {name: 'Remy', cohort: 'Jan'},
    {name: 'Genevieve', cohort: 'March'},
    {name: 'Chuck', cohort: 'Jan'},
    {name: 'Osmund', cohort: 'June'},
    {name: 'Nikki', cohort: 'June'},
    {name: 'Boris', cohort: 'June'}
];
let users = {
    employees: [
        {'first_name':  'Miguel', 'last_name' : 'Jones'},
        {'first_name' : 'Ernie', 'last_name' : 'Bertson'},
        {'first_name' : 'Nora', 'last_name' : 'Lu'},
        {'first_name' : 'Sally', 'last_name' : 'Barkyoumb'}
    ],
    managers: [
       {'first_name' : 'Lillian', 'last_name' : 'Chambers'},
       {'first_name' : 'Gordon', 'last_name' : 'Poe'}
    ]
 };

function allStudents(arr)
{
    for(var student in arr)
    {
        var string = "";
        string += `Name: ${arr[student].name}, `;
        string += `Cohort: ${arr[student].cohort}`;
        console.log(string);
    }
    console.log("****************************************");
}
function allUsers(arr)
{
    for(var key in arr)
    {
        console.log(key);
        var x = 1;
        for( var user in arr[key])
        {
            var count = 0;
            for(var letter in arr[key][user].first_name)
            {
               count += 1;
            }
            for(var letter in arr[key][user].last_name)
            {
                count += 1;
            }
            var string = "";
            string +=  `${x} - ${arr[key][user].last_name}, ${arr[key][user].first_name} - ${count}`;
            console.log(string);
            x++;
        }

    }
}


allStudents(students);
allUsers(users);

