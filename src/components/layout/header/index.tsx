import { FC } from "react";
import { Link } from "react-router-dom";

export const Header: FC = () => {
   return (
      <header className="container mx-auto">
         <nav className="h-16 flex items-center border-b">
            <Link to="/" className="flex gap-x-2">
               <img className="h-8 w-8" src="logo.png" />
               <span className="leading-8 font-medium text-gray-800">Все Буде Україна</span>
            </Link>
         </nav>
      </header>
   )
}