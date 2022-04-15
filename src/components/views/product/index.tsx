import { FC } from "react";
import { Details } from "./sections/details";
import { Gallery } from "./sections/gallery";

export const ProductView: FC = () => {
   return (
      <div className="flex gap-x-8 py-4">
         <div className="w-3/5">
            <Gallery />
         </div>
         <div className="flex-1">
            <Details />
         </div>
      </div>
   )
};