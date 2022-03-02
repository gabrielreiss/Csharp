class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    ExpectedMinutesInOven(){
        return 40;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    RemainingMinutesInOven(int valor){
        return 40 - valor;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    PreparationTimeInMinutes(int valor){
        return valor * 2;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    ElapsedTimeInMinutes(int layers, int oven){
        return layers * 2 + oven;
    }

}
