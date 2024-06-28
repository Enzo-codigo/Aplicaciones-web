export class Guide {
    constructor(id, name, destination, language, specialization, availability,
                rate, price, experience, picture) {
        this.id = id;
        this.name = name;
        this.destination = destination;
        this.language = language;
        this.specialization = specialization;
        this.availability = availability;
        this.rate = rate;
        this.price = price;
        this.experience = experience;
        this.picture = picture;
    }

    static FromDisplayableGuide(displayableGuide) {
        return new Guide(displayableGuide.id, displayableGuide.name,
            displayableGuide.destination, displayableGuide.language,
            displayableGuide.specialization, displayableGuide.availability,
            displayableGuide.rate, displayableGuide.price,
            displayableGuide.experience, displayableGuide.picture,);
    }

    static toDisplayableGuide(guide) {
        return {
            id: guide.id,
            name: guide.name,
            destination: guide.destination,
            language: guide.language,
            specialization: guide.specialization,
            availability: guide.availability,
            rate: guide.rate,
            price: guide.price,
            experience: guide.experience,
            picture: guide.picture,
        };
    }
}