/// This is used to issue greeting messages.
pub struct Greeter {
    name: String,
}

impl Greeter {
    pub fn new (name: &str) -> Greeter {
        Greeter {
            name: name.to_string(),
        }
    }
}

impl Greeter {
    /// Says hello!
    pub fn say_hello(&self) {
        println!("Hello {0}!", self.name);
    }
}

impl Greeter {
    /// Says goodbye!
    pub fn say_goodbye(&self) {
        println!("Goodbye {0}!", self.name);
    }
}

fn main() {
    let my_greeter = Greeter::new("Jim");

    my_greeter.say_hello();
    my_greeter.say_goodbye();
}
