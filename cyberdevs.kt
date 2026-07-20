data class CyberDevs(
    val name: String = "CyberDevs",
    val location: String = "Islamabad, Pakistan",
    val specialties: List<String> = listOf("Android Development", "Game Creation", "Cybersecurity")
) {
    fun greet() {
        println("🌌 Welcome to the official repository of $name!")
        println("📍 Based in $location")
        println("⚡ Our Specialties:")
        specialties.forEach { println("  - $it") }
    }
}

fun main() {
    val devs = CyberDevs()
    devs.greet()
}
