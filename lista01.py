import math

class Circulo:
    def __init__(self, raio):
        self.raio = raio
    
    def calcular_area(self):
        return math.pi * self.raio ** 2 #πr²
    
    def calcular_circunferencia(self):
        return 2 * math.pi * self.raio

def testar_circulo():
    circulo = Circulo(10)
    
    area = circulo.calcular_area()
    circunferencia = circulo.calcular_circunferencia()
    
    print(f"Raio: {circulo.raio}")
    print(f"Área do círculo: {area:.2f}")
    print(f"Circunferência do círculo: {circunferencia:.2f}")

testar_circulo()
