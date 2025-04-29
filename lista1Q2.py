class Viagem():
    def __init__(self, distancia_km, tempo_horas, tempo_minutos):   
        self.distancia_km = distancia_km
        self.tempo_horas = tempo_horas
        self.tempo_minutos = tempo_minutos
    
    def calcular_velocidade_media(self):
        tempo_total = self.tempo_horas + self.tempo_minutos / 60
        velocidade_media = self.distancia_km / tempo_total
        return velocidade_media
    
viagem = Viagem(150, 2, 30)
velocidade = viagem.calcular_velocidade_media()
print(f"A velocidade media da viagem foi de {velocidade:.2f} km/h")


