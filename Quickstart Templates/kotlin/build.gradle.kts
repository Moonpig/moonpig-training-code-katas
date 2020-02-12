plugins {
    kotlin("jvm") version "1.3.61"
}

group = "moonpig"
version = "1.0-SNAPSHOT"

repositories {
    mavenCentral()
}

dependencies {
    implementation(kotlin("stdlib-jdk8"))

    testImplementation("junit:junit:4.13")
    testImplementation("org.assertj:assertj-core:3.15.0")
}

tasks {
    compileKotlin {
        kotlinOptions.jvmTarget = "1.8"
    }
    compileTestKotlin {
        kotlinOptions.jvmTarget = "1.8"
    }
}