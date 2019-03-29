class BankAccount:
    def __init__(self, rate, balance):
        self.balance = balance
        self.rate = rate
    
    def deposit(self, amount):
        self.balance = self.balance + amount
        return self
    def withdrawl(self, amount):
        self.balance = self.balance - amount
        return self
    def yield_interest(self, rate):
        print(self.rate)
        return self
    def display_info(self):
        print("Balance:", self.balance, "Interest Rate:", self.rate)
        return self
amanda = BankAccount(20, 300)
brock = BankAccount(15, 600)

amanda.deposit(100).deposit(400).deposit(50).withdrawl(450).display_info()
brock.deposit(500).deposit(50).withdrawl(50).withdrawl(23).withdrawl(60).withdrawl(60).display_info()