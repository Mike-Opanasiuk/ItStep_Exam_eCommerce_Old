import { FC } from "react";
import { IconProps } from "../props";

export const IconArrow: FC<IconProps> = ({ className }) => {
   return (
      <svg className={className} viewBox="0 0 14 12" fill="none" xmlns="http://www.w3.org/2000/svg">
         <path d="M1.5 6H12.5" stroke="currentColor" strokeWidth="1.5" strokeLinecap="round" strokeLinejoin="round" />
         <path d="M8 1.5L12.5 6L8 10.5" stroke="currentColor" strokeWidth="1.5" strokeLinecap="round" strokeLinejoin="round" />
      </svg>
   );
};