import ICategory from './ICategory';
import IQuantitieType from './IQuantitieType';

export default interface IProduct{
    ID: string;
    Name: string;
    ImageURL: string;
    Grams: number;
    QuantitieTypes: IQuantitieType[];
    Description: string;
    Categories: ICategory[];
}