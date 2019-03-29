class user:
    def __init__(self, user, balance):
        self.balance = balance
    def make_withdrawl(self, amount):
        self.balance = self.balance - amount
        print(self.balance)
        return self
    def display_user_balance(self):
        print(self.balance)
        return self
    def make_deposit(self, amount):
        self.balance += amount
        print(self.balance)
        return self
guido = user(1, 150)
guido.make_deposit(200).make_withdrawl(100).display_user_balance()