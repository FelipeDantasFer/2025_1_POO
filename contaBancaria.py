class Conta_bancaria():
    def __init__(self, nome_titular, numero_conta, saldo_inicial=0.0):
        self.nome_titular = nome_titular
        self.numero_conta = numero_conta
        self.saldo = saldo_inicial

    def deposito(self, valor):
        if valor > 0:
            self.saldo += valor
            print(f"O deposito de R$ {valor:.2f} foi realizado com sucesso!!!")
        else:
            print("Valor de deposito tem que ser maior que zero.")

    def saque(self, valor):
        if valor > 0:
            if valor <= self.saldo:
                self.saldo -= valor
                print(f"Saque de R$ {valor:.2f} realizado com sucesso!!!")
            else:
                print("Saldo insuficiente para saque.")
        else:
            print("Valor tem que ser positivo.")

    def exibir_saldo(self):
        print(f"O numero da conta é {self.numero_conta}: R$ {self.saldo:.2f} ")


conta = Conta_bancaria("Felipe Fernandes", 2002.2525, 2500 )
conta.exibir_saldo
conta.deposito(2500)
conta.saque(500)
conta.exibir_saldo

