class CyberDevs:
    def __init__(self):
        self.name = "CyberDevs"
        self.location = "Islamabad, Pakistan"
        self.specialties = ["Android Development", "Game Creation", "Cybersecurity"]

    def greet(self):
        print(f"🌌 Welcome to the official repository of {self.name}!")
        print(f"📍 Based in {self.location}")
        print("⚡ Our Specialties:")
        for spec in self.specialties:
            print(f"  - {spec}")

if __name__ == "__main__":
    devs = CyberDevs()
    devs.greet()
