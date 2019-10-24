let button_beregn: HTMLButtonElement = <HTMLButtonElement>document.getElementById("BeregnAfgift");

function beregnPbil(pris: number)
{
    let bilAfgift: number;

    if(pris > 200000)
    {
        bilAfgift = (pris * 1.5) - 130000;
    }
    else if (pris <= 200000)
    {
        bilAfgift = pris * 0.85;
    }
    return bilAfgift;
}

function beregnElbil(pris: number)
{
   
    let bilAfgift: number;

    if(pris > 200000)
    {
        bilAfgift = (pris * 1.5) - 130000;
    }
    else if (pris <= 200000)
    {
        bilAfgift = pris * 0.85;
    }
    let ElbilAfgift: number = bilAfgift * 0.20

    return ElbilAfgift;
}

button_beregn.addEventListener("click", () => 
{
    let inputElement: HTMLInputElement = <HTMLInputElement>document.getElementById("input_pris");
    let outputElement: HTMLDivElement = <HTMLDivElement>document.getElementById("output");

    let inputNumber: number = +inputElement.value;

    let bilType = (<HTMLSelectElement>document.getElementById('dropDown_bilType')).value;

    let bilPris: number;

 if (bilType == "Bil")
        bilPris = beregnPbil(inputNumber);
    else if (bilType == "ElBil")
        bilPris = beregnElbil(inputNumber);
    else
        bilPris = 0;

    outputElement.innerHTML = bilPris.toString();
});


    

