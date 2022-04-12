import { FC } from "react";
import { Link } from "react-router-dom";

interface Props {
   name: string;
   picture: string;
   price: number;
}

export const Card: FC<Props> = ({ name, picture, price }) => {
   return (
      <Link to="/product" className="hover:bg-gray-300">
         <img className="w-full h-80 object-cover" src={picture} />
         <div className="flex justify-between mt-1">
            <span>{name}</span>
            <span className="font-medium">${price}</span>
         </div>
      </Link>
   )
}