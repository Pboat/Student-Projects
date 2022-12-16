/*
Daniel Bruce
2/9/2022
This module is for converting between various units of measurement.
Each function provides a different kind of conversion.
*/
//conversion factors obtained from google's unit conversion calculator
let conversion = function convert(value){
    this.unit = value;
    this.foot_to_meter = function(){
        return Math.round((value / 3.281)*1000)/1000; //rounds division to 3 decimal places
    }
    this.meter_to_foot = function(){
        return value * 3.281;
    }
    this.kilo_to_mile = function(){
        return Math.round((value / 1.609)*1000)/1000;
    }
    this.mile_to_kilo = function(){
        return value * 1.609;
    }
    this.sqft_to_acres = function(){
        return Math.round((value / 43560)*1000)/1000;
    }
    this.acres_to_sqft = function(){
        return value * 43560;
    }
    this.gallon_to_cup = function(){
        return value * 15.773;
    }
    this.pounds_to_kg = function(){
        return Math.round((value / 2.205)*1000)/1000;
    }
};

exports.conversion = conversion;
