
class user:
    def __init__(self, user, balance):
        self.balance = balance
    def make_withdrawl(self, amount):
        self.balance -= amount
        return self.balance
    def display_user_balance(self):
        print(self.balance)
guido = user(1, 150)
print(guido.balance)
print(guido.make_withdrawl(100))
guido.display_user_balance()