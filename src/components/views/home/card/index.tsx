import { FC } from "react";
import { Link } from "react-router-dom";

import { uid } from "uid";

interface Props {
   name: string;
   picture: string;
   price: number;
}

export const Card: FC<Props> = ({ name, picture, price }) => {
   return (
      <Link to={`/product/${uid(6)}`} className="overflow-hidden flex flex-col border-r pr-4 last:p-0 last:border-0">
         <img className="h-60 w-full p-1 object-contain" src={picture} />
         <span className="font-medium mt-2">{name}</span>
         <span>${price}</span>
      </Link>
   )
}