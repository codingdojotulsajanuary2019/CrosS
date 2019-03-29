class BankAccount:
    def __init__(self, int_rate, balance):
        self.balance = balance
        self.int_rate = int_rate
    
    def deposit(self, amount):
        self.balance = self.balance + amount
        return self
    def withdrawl(self, amount):
        self.balance = self.balance - amount
        return self

class user:
    def __init__(self, name, email):
        self.name = name
        self.email = email
        self.account = BankAccount(int_rate = 0.02, balance = 150)
   
    def make_withdrawl(self, amount):
        self.account.withdrawl(amount)
        print(self.account.balance)
    def make_deposit(self, amount):
        self.account.deposit(amount)
        print(self.account.balance)
    def display_user_info(self):
        print("Balance:", self.account.balance)
        print("Interest Rate:", self.account.int_rate)
jeremy = user("jeremy", "jeremy@mail.com")
jeremy.display_user_info()
jeremy.make_deposit(300)
jeremy.make_withdrawl(100)