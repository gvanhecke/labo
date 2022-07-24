 const onLoad = () => {

    const yearDiff = from => to => {
        const secs = (to.getTime() - from.getTime())/1000;
        const days = secs/86400;
        const years = Math.abs(Math.round(days/365.25));
        return years;
    }


    //compute dynamically the number of years since the begin of my career
    const today = new Date(new Date(Date.now()).setHours(0,0,0,0));
    const careerStartedOn = new Date(new Date(2005,7,01).setHours(0,0,0,0));
    const years = yearDiff(careerStartedOn)(today);

    //add years of experience in the DOM
    document.querySelector('#experience').textContent = years;
} 
