class BankAccount:
    def __init__(self, owner, balance):
        self.owner = owner           # Public attribute
        self.__balance = balance     # Private attribute

    # Getter method to access private attribute
    def get_balance(self):
        return self.__balance

    # Setter method to modify private attribute
    def deposit(self, amount):
        if amount > 0:
            self.__balance += amount
        else:
            print("Invalid deposit amount!")

    def withdraw(self, amount):
        if 0 < amount <= self.__balance:
            self.__balance -= amount
        else:
            print("Insufficient funds or invalid amount!")