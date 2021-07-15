package com.company;
import java.util.*;
public class Main {
    static Double[] values = {0.0070, 0.0074, 2.3428, 3.1430, 1.0000, 0.0041};
    static HashMap<String, Integer>  hash = new HashMap<String, Integer>();
    public static void main(String[] args) {

        hash.put("AED", 0);
        hash.put("AMD", 1);
        hash.put("AUD", 2);
        hash.put("USD", 3);
        hash.put("GEL", 4);
        hash.put("JPY", 5);

        System.out.println(exchangeRate("GEL","AMD"));
    }
    static Double exchangeRate(String from, String to){
        int fromIndex = hash.get(from);
        int toIndex = hash.get(to);
        Double rate = 0.0;

        rate = values[fromIndex]/values[toIndex];
        rate = (double)Math.round(rate * 10000)/10000;

        return rate;
    }
}
