const cyberDevs = {
    name: "CyberDevs",
    location: "Islamabad, Pakistan",
    specialties: ["Android Development", "Game Creation", "Cybersecurity"],
    greet() {
        console.log(`🌌 Welcome to the official repository of ${this.name}!`);
        console.log(`📍 Based in ${this.location}`);
        console.log("⚡ Our Specialties:");
        this.specialties.forEach(spec => console.log(`  - ${spec}`));
    }
};

cyberDevs.greet();
