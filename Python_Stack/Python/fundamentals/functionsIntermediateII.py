'''
x = [ [5,2,3], [10,8,9] ] 
students = [
     {'first_name':  'Michael', 'last_name' : 'Jordan'},
     {'first_name' : 'John', 'last_name' : 'Rosales'}
]
sports_directory = {
    'basketball' : ['Kobe', 'Jordan', 'James', 'Curry'],
    'soccer' : ['Messi', 'Ronaldo', 'Rooney']
}
z = [ {'x': 10, 'y': 20} ]

for i in range(0, len(x), 1):
    x[1][0] = 15
print(x)
students[0]["last_name"] = "Bryant"
print(students)

for i in range(0, len(sports_directory), 1):
    sports_directory["soccer"][0] = "Andres"
print(sports_directory["soccer"])

z[0]["y"] = 30
print(z)
'''
'''
students = [
         {'first_name':  'Michael', 'last_name' : 'Jordan'},
         {'first_name' : 'John', 'last_name' : 'Rosales'},
         {'first_name' : 'Mark', 'last_name' : 'Guillen'},
         {'first_name' : 'KB', 'last_name' : 'Tonel'}
    ]
def iterateDictionary(list):
    for x in range(0, len(list), 1):
        print(list[x])
iterateDictionary(students)


# should output: (it's okay if each key-value pair ends up on 2 separate lines;
# bonus to get them to appear exactly as below!)
'''
'''
students = [
         {'first_name':  'Michael', 'last_name' : 'Jordan'},
         {'first_name' : 'John', 'last_name' : 'Rosales'},
         {'first_name' : 'Mark', 'last_name' : 'Guillen'},
         {'first_name' : 'KB', 'last_name' : 'Tonel'}
    ]

def iterateDictionary2(list, key):
    for x in range(0, len(list), 1):
        print(list[x][key])
iterateDictionary2(students,"first_name")
'''
dojo = {
   'locations': ['San Jose', 'Seattle', 'Dallas', 'Chicago', 'Tulsa', 'DC', 'Burbank'],
   'instructors': ['Michael', 'Amy', 'Eduardo', 'Josh', 'Graham', 'Patrick', 'Minh', 'Devon']
}
'''
def printInfo(dojo):
    for i in range(0, 1, 1):
        print(len(dojo["locations"]))
        print("locations")
        print(dojo["locations"]) 
        print(len(dojo["instructors"]))
        print("instructors")
        print(dojo["instructors"])
printInfo(dojo)
'''
